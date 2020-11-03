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
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x65252A, new byte[] { 0x90, 0x90 });
        }

        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x65252A, new byte[] { 0x74, 0x14 });
        }
    }

}