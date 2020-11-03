using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace WaveClient.Module
{
    public static class Instabreak
    {
        public static bool ToggleState;


        public static void Tick10()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x154E0DF, new byte[] { 0xF3, 0x0F, 0x11, 0x57, 0x20 });
        }
        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x154E0DF, new byte[] { 0xF3, 0x0F, 0x11, 0x4F, 0x20 });
        }
    }

}