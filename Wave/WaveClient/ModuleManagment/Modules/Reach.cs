using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class Reach
    {
        public static bool ToggleState;

        public static void Tick10()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x2409B78, new byte[] { 0xF3, 0x0F, 0x10, 0x05, 0x12, 0xB7, 0xAA, 0x01 });
        }

        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x2409B78, new byte[] { 0xF3, 0x0F, 0x10, 0x05, 0xFA, 0xB5, 0xAA, 0x01 });
        }
    }

}