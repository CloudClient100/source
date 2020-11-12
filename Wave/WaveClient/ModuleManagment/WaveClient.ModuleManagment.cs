﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using WaveClient.Module;
using Wave.Cmr.MemoryManagement;
using WaveClient.ModuleManagment;


namespace WaveClient.ModuleManagment
{
    public static class ModuleManager
    {
        public static class MemoryUpdate
        {

            //
            public static void Tick10()
            {
            while (!ExitTickThread)
                {
                    if(Module.AirJump.ToggleState == true)
                    {
                        Module.AirJump.Tick10();
                    }
                    if(Module.NoFall.ToggleState == true)
                    {
                        Module.NoFall.Tick10();
                    }
                    if (Module.Instabreak.ToggleState == true)
                    {
                        Module.Instabreak.Tick10();
                    }
                    if (Module.Reach.ToggleState == true)
                    {
                        Module.Reach.Tick10();
                    }
                    if (Module.NoSwing.ToggleState == true)
                    {
                        Module.NoSwing.Tick10();
                    }
                    if (Module.Coords.ToggleState == true)
                    {
                        Module.Coords.Tick10();
                    }
                    if (Module.Speed.ToggleState == true)
                    {
                        Module.Speed.Tick10();
                    }
                    if (Module.AutoSprint.ToggleState == true)
                    {
                        Module.AutoSprint.Tick10();
                    }
                    //
                    if (Module.KillYourSelf.ToggleState == true)
                    {
                        Module.KillYourSelf.Enable();
                    }
                    if (Module.Phase.ToggleState == true)
                    {
                        //Module.Phase.
                        Module.Phase.Tick10();
                    }
                    if (Module.Noclip.ToggleState == true)
                    {
                        Module.Noclip.Tick10();
                    }
                    if (Module.AnvilCost.ToggleState == true)
                    {
                        Module.AnvilCost.Tick100();
                    }
                    ///////////////////
                    if (Module.AirJump.ToggleState == false)
                    {
                        
                    }
                    if(Module.NoFall.ToggleState == false)
                    {

                    }
                    if (Module.Instabreak.ToggleState == false)
                    {
                        Module.Instabreak.Disable();
                    }
                    if (Module.Reach.ToggleState == false)
                    {
                        Module.Reach.Disable();
                    }
                    if (Module.NoSwing.ToggleState == false)
                    {
                        Module.NoSwing.Disable();
                    }
                    if (Module.Coords.ToggleState == false)
                    {
                        Module.Coords.Disable();
                    }
                    if (Module.Speed.ToggleState == false)
                    {

                    }
                    if (Module.AutoSprint.ToggleState == false)
                    {
                        
                    }
                    if (Module.Phase.ToggleState == false)
                    {
                        Module.Phase.Disable();
                    }
                    if (Module.Noclip.ToggleState == false)
                    {
                        Module.Noclip.Disable();
                    }
                    if(Module.Autoclicker.ToggleState == false)
                    {
                        Module.Autoclicker.Tick10();
                    }
                    if(Module.Autoclicker.ToggleState == false)
                    {

                    }
                    if (Module.KillYourSelf.ToggleState == false)
                    {
                        
                    }
                    if (Module.Noclip.ToggleState == false)
                    {
                        
                    }
                }
            }

            public static void Tick100()
            {
                while (!ExitTickThread)
                {
                    Thread.Sleep(10);
                }
            }

            public static void Tick1000()
            {
                while (!ExitTickThread)
                {
                    Thread.Sleep(10);
                }
            }

            #region Def
            public static void StartTickThread()
            {
                ThreadTimerTick10 = new Thread(new ThreadStart(Tick10));
                ThreadTimerTick100 = new Thread(new ThreadStart(Tick100));
                ThreadTimerTick1000 = new Thread(new ThreadStart(Tick1000));

                ThreadTimerTick10.Priority = ThreadPriority.Normal;
                ThreadTimerTick100.Priority = ThreadPriority.Normal;
                ThreadTimerTick1000.Priority = ThreadPriority.BelowNormal;

                ThreadTimerTick10.Start();
                ThreadTimerTick100.Start(); 
                ThreadTimerTick1000.Start();
            }

            public static void RestartTickThread()
            {
                ThreadTimerTick10.Abort();
                ThreadTimerTick100.Abort();
                ThreadTimerTick1000.Abort();

                StartTickThread();
            }

            public static bool ExitTickThread = false;

            static Thread ThreadTimerTick10;
            static Thread ThreadTimerTick100;
            static Thread ThreadTimerTick1000;
            #endregion
        }
    }
}
