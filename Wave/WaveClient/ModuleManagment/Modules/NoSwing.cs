using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class NoSwing
    {
        public static bool ToggleState;


        public static void Tick10()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x9567C4, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
        }
        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x9567C4, new byte[] { 0xC6, 0x83, 0x9C, 6, 0, 0, 1 });
        }
    }

}