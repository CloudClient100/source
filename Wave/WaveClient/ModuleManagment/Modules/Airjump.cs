using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class AirJump
    {
        public static bool ToggleState;

        static Pointer OnGround = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0 }); //0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0

        
        public static void Tick10()
        {
            Memory0.mem.WriteMemory(OnGround, 16777473);
        }
        
    }
    
}