using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Cmr.MemoryManagement;
using WaveClient.SDK;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace WaveMemory

{
    public class Mem
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(char vKey);

        [DllImport("kernel32", SetLastError = true)]
        public static extern int ReadProcessMemory(IntPtr hProcess, ulong lpBase, ref ulong lpBuffer, int nSize, int lpNumberOfBytesRead);

        [DllImport("kernel32", SetLastError = true)]
        public static unsafe extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, void* lpBuffer, int nSize, int lpNumberOfBytesWritten); //with IntPtr lpBuffer

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, out FOURSIDE lpRect);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        public static extern short VkKeyScan(char ch);

        public static Process mcProcess;
        public static ProcessModule mcMainModule;
        public static uint mcProcessId;
        public static uint mcWindowProcessId;
        public static IntPtr mcBaseAddress;
        public static IntPtr mcWindowHandle;
        public static IntPtr mcProcessHandle;


        public struct FOURSIDE
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void openMc() //Minecraft
        {
            Process[] processes = Process.GetProcessesByName("Minecraft.Windows");
            Process mcwindows10 = processes[0];
            IntPtr process = OpenProcess(0x1F0FFF, false, mcwindows10.Id);

            mcProcessId = (uint)mcwindows10.Id;
            mcProcess = mcwindows10;
            mcProcessHandle = process;

            mcMainModule = mcwindows10.MainModule;
            mcBaseAddress = mcMainModule.BaseAddress;
        }

        public static void openWindowH() //McWindow  (need both Minecraft.Windows and ApplicationFrameHost for this client.)
        {
            Process[] processes = Process.GetProcessesByName("ApplicationFrameHost");

            mcWindowHandle = processes[0].MainWindowHandle;
            mcWindowProcessId = (uint)processes[0].Id;
        }

        public static FOURSIDE getMcRect()
        {
            FOURSIDE mcRect = new FOURSIDE();
            GetWindowRect(mcWindowHandle, out mcRect);
            return mcRect;
        }

        public static bool isMcFocused()
        {
            StringBuilder sb = new StringBuilder("Minecraft".Length + 1);
            GetWindowText(GetForegroundWindow(), sb, "Minecraft".Length + 1);
            return sb.ToString().CompareTo("Minecraft") == 0;
        }

        public static IntPtr isMcFocused1()
        {
            StringBuilder sb = new StringBuilder("Minecraft".Length + 1);
            GetWindowText(GetForegroundWindow(), sb, "Minecraft".Length + 1);
            if (sb.ToString() == "Minecraft")
            {
                return (IntPtr)(-1);
            }
            else
            {
                return (IntPtr)(-2);
            }
        }

        public static byte[] CheatEngineByteTobytes(string byteString) //Cheat Engine bytes to real bytes
        {
            string[] byteStr = byteString.Split(' ');
            byte[] bytes = new byte[byteStr.Length];

            int gay = 0;
            foreach (string b in byteStr)
            {
                bytes[gay] = (Convert.ToByte(b, 16));
                gay++;
            }
            return bytes;
        }

        public static int[] CheatEngineByteToIntegers(string byteString) //Cheat Engine bytes to real Integers
        {
            string[] intStr = byteString.Split(' ');
            int[] ints = new int[intStr.Length];

            int gay = 0;
            foreach (string b in intStr)
            {
                ints[gay] = (int.Parse(b, System.Globalization.NumberStyles.HexNumber));
                gay++;
            }
            return ints;
        }

        public static ulong[] CheatEngineByteToUlongs(string byteString)  //Cheat Engine bytes to real Ulongs
        {
            string[] intStr = byteString.Split(' ');
            ulong[] longs = new ulong[intStr.Length];

            int gay = 0;
            foreach (string b in intStr)
            {
                longs[gay] = (ulong.Parse(b, System.Globalization.NumberStyles.HexNumber));
                gay++;
            }
            return longs;
        }

        public static ulong EvaluatePointer(ulong addr, ulong[] offsets)
        {
            ulong buffer = 0;
            ReadProcessMemory(mcProcessHandle, addr, ref buffer, sizeof(ulong), 0);
            for (int gay = 0; gay < offsets.Length - 1; gay++)
            {
                ReadProcessMemory(mcProcessHandle, (ulong)(buffer + offsets[gay]), ref buffer, sizeof(ulong), 0);
            }
            return buffer + offsets[offsets.Length - 1];
        }

        public static ulong BaseEvaluatePointer(ulong offset, ulong[] offsets)
        {
            ulong buffer = 0;
            ReadProcessMemory(mcProcessHandle, (ulong)mcBaseAddress + offset, ref buffer, sizeof(ulong), 0);
            for (int gay = 0; gay < offsets.Length - 1; gay++)
            {
                ReadProcessMemory(mcProcessHandle, (ulong)(buffer + offsets[gay]), ref buffer, sizeof(ulong), 0);
            }
            return buffer + offsets[offsets.Length - 1];
        }

        //Write Section

        public static unsafe void Write<T>(ulong address, T value) where T : unmanaged
        {
            WriteProcessMemory(mcProcessHandle, (IntPtr)address, (void*)&value, sizeof(T), 0);
        }

        public static unsafe void WriteBase<T>(ulong offset, T value) where T : unmanaged
        {
            Write((ulong)mcBaseAddress + offset, value);
        }

        public static void WriteBaseBytes(ulong offset, byte[] value)
        {
            for (uint i = 0; i < value.Length; i++)
                Write((ulong)mcBaseAddress + offset + i, value[i]);
        }

        public static void WriteBytes(ulong address, byte[] value)
        {
            for (uint i = 0; i < value.Length; i++)
                Write(address + i, value[i]);
        }

        public static void WriteString(ulong address, string str) //10 - Last write.
        {
            for (uint i = 0; i < str.Length; i++)
                Write(address + i, (byte)str[(int)i]);
            Write(address + (uint)str.Length, (byte)0);
        }

        public static void WriteWideString(ulong address, string str) //10 - Last write.
        {
            for (uint i = 0; i < str.Length; i++)
                Write(address + i, (short)str[(int)i]);
            Write(address + (uint)str.Length, (byte)0);
        }

        //Read Section

        public static unsafe T Read<T>(ulong address) where T : unmanaged//14
        {
            ulong buffer = 0;
            ReadProcessMemory(mcProcessHandle, address, ref buffer, sizeof(T), 0);
            return *(T*)((void*)&buffer);
        }


        public static string szRead(ulong address)
        {
            string f = "";
            uint i = 0;
            byte read = 0;
            for (; ; )
            {
                read = Read<byte>(address + i);
                i++;
                if (read != 0)
                    f += (char)read;
                else
                    return f;
            }
        }

        public static string szPtrRead(ulong address)
        {
            return szRead(Read<ulong>(address));
        }
    }
}