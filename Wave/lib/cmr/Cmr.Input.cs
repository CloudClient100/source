using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Cmr.Win32API;

namespace Wave.Cmr
{
    public static class cmr_input
    {
        public static bool GetKeyStateDown(Win32.VirtualKeys vk)
        {
            return Convert.ToBoolean(Win32.GetAsyncKeyState(vk) & 0x8000);
        }

        public static bool GetKeyStateDown(Win32.VK vk)
        {
            return Convert.ToBoolean(Win32.GetAsyncKeyState(vk) & 0x8000);
        }

        public static bool GetKeyStateUp(Win32.VirtualKeys vk)
        {
            return !Convert.ToBoolean(Win32.GetAsyncKeyState(vk) & 0x8000);
        }

        public static bool GetKeyStateUp(Win32.VK vk)
        {
            return !Convert.ToBoolean(Win32.GetAsyncKeyState(vk) & 0x8000);
        }
    }
}
