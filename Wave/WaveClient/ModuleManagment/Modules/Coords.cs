﻿using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace WaveClient.Module
{
    public static class Coords
    {
        public static bool ToggleState;


        public static void Tick10()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x680C6D, new byte[] { 0x90, 0x90, 0x90, 0x90 });
        }

        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x680C6D, new byte[] { 0x80, 0x78, 0x04, 0x00 });
        }

    }

}