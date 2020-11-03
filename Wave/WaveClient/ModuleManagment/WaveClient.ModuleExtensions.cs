using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveClient.ModuleManagment.ModuleExtensions
{
    public class GUIExtensions
    {
        public static string GetBoolStateText(bool State)
        {
            if (State == true)
            {
                return "On";
            } else
            {
                return "Off";
            }
        }

        public static string GetModuleListString()
        {
            return "";
        }
    }
}
