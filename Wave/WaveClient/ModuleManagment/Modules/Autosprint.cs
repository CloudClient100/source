using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class AutoSprint
    {
        public static bool ToggleState;

        static Pointer autosprintPointer = new Pointer("Minecraft.Windows.exe", 0x03655720, new int[] { 0xA8, 0x10, 0x7C8, 0x0, 0x128, 0x8, 0x80, 0xC });
        private static float sprintvalue = 1;


        public static void Tick10()
        {
            Memory0.mem.WriteMemory(autosprintPointer, 0);
        }

        public static void Disabled()
        {
            //
        }
    }

}