using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{

    public static class Speed
    {
        public static bool ToggleState;

        static Pointer SpeedPointer = new Pointer("Minecraft.Windows.exe", 0x03655720, new int[] { 0xA8, 0x58, 0x38, 0x10, 0x438, 0x18, 0x1F0, 0x9C });

        public static void Tick100()
        {
            Memory0.mem.WriteMemory(SpeedPointer, 1f);
        }

    }

}