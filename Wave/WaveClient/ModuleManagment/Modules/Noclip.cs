using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class Noclip
    {
        public static bool ToggleState;

        static Pointer noclipptr = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x0, 0x18, 0x90, 0xA8, 0xFB8, 0x18, 0x918 });

        public static void Tick10()
        {
            Memory0.mem.WriteMemory(noclipptr, 1);
        }

        public static void Disable()
        {
            Memory0.mem.WriteMemory(noclipptr, 0);
        }

    }

}