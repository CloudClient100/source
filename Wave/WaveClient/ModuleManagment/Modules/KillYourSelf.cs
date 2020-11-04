using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class KillYourSelf
    {
        public static bool ToggleState;

        static Pointer kys = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0x19C });


        public static void Tick10()
        {
           Memory0.mem.WriteMemory(kys, 999);
        }
    }
    
}
