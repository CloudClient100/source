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

        static Pointer yPos = new Pointer("Minecraft.Windows.exe", 0x036A0238, new int[] { 0x10, 0x18, 0x80, 0x9F8, 0x18, 0x45C }); 
        
        public static void Tick10()
        {

        }
        
        public static void Enable()
        {
            float currentYPos = Memory0.mem.ReadFloat(yPos)
            Memory0.mem.WriteMemory(yPos, currentYPos+2f)
        }    
    }
    
}
