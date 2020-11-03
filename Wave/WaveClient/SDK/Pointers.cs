using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Cmr;
using Wave.Cmr.MemoryManagement;
using WaveClient.Module;
using WaveClient.ModuleManagment;

namespace WaveClient.SDK
{
    public class Pointers
    {
        public static Pointer instabreakptr = new Pointer("Minecraft.Windows.exe", 0x154E0DF, new int[] { 0xF3, 0x0F, 0x11, 0x57, 0x20 }); //0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0
    }
}
