using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;
using Wave.Cmr;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace WaveClient.Module
{
    public static class Phase
    {
        public static bool ToggleState;

        static Pointer yPos = new Pointer("Minecraft.Windows.exe", 0x036A0238, new int[] { 0x10, 0x18, 0x80, 0x9F8, 0x18, 0x45C});

        static float currentYPos = Memory0.mem.ReadFloat(yPos);

        public static void Tick10()
        {

        }

        public static void Enable()
        {
            Console.WriteLine(currentYPos);
            Memory0.mem.WriteMemory(yPos, currentYPos + 2);
        }

    }

}