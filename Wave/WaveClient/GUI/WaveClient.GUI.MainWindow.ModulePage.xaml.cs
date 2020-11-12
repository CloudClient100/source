﻿using WaveClient.ModuleManagment;
using WaveClient.ModuleManagment.ModuleExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WaveClient.GUI
{
    /// <summary>
    /// Interaction logic for WaveClient.xaml
    /// </summary>
    public partial class MainWindow_ModulePage : Page
    {
        DispatcherTimer UpdateGUIDispatcherTimer;

        public MainWindow_ModulePage()
        {
            InitializeComponent();

            #region UpdateGUIDispatcherTimer
            UpdateGUIDispatcherTimer = new DispatcherTimer();
            UpdateGUIDispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            UpdateGUIDispatcherTimer.Tick += new EventHandler(UpdateGUI);
            UpdateGUIDispatcherTimer.Start();
            #endregion
        }

        ~MainWindow_ModulePage()
        {
            UpdateGUIDispatcherTimer.Stop();
        }

        public void UpdateGUI(object sender, EventArgs e)
        {
            SModule_Airjump.Content = GUIExtensions.GetBoolStateText(Module.AirJump.ToggleState);
            SModule_NoFall.Content = GUIExtensions.GetBoolStateText(Module.NoFall.ToggleState);
            SModule_Instabreak.Content = GUIExtensions.GetBoolStateText(Module.Instabreak.ToggleState);
            SModule_Reach.Content = GUIExtensions.GetBoolStateText(Module.Reach.ToggleState);
            SModule_NoSwing.Content = GUIExtensions.GetBoolStateText(Module.NoSwing.ToggleState);
            SModule_Coords.Content = GUIExtensions.GetBoolStateText(Module.Coords.ToggleState);
            SModule_Speed.Content = GUIExtensions.GetBoolStateText(Module.Speed.ToggleState);
            SModule_AutoSprint.Content = GUIExtensions.GetBoolStateText(Module.AutoSprint.ToggleState);
            SModule_KillYourSelf.Content = GUIExtensions.GetBoolStateText(Module.KillYourSelf.ToggleState);
            SModule_Phase.Content = GUIExtensions.GetBoolStateText(Module.Phase.ToggleState);
            SModule_Noclip.Content = GUIExtensions.GetBoolStateText(Module.Noclip.ToggleState);
            SModule_Autoclicker.Content = GUIExtensions.GetBoolStateText(Module.Autoclicker.ToggleState);
            SModule_AnvilCost.Content = GUIExtensions.GetBoolStateText(Module.AnvilCost.ToggleState);
            SModule_HighJump.Content = GUIExtensions.GetBoolStateText(Module.HighJump.ToggleState);
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.StickyGround.ToggleState);
            SModule_AirWalk.Content = GUIExtensions.GetBoolStateText(Module.AirWalk.ToggleState);
        }

        private void SModule_Airjump_Click(object sender, RoutedEventArgs e)
        {
            Module.AirJump.ToggleState = !Module.AirJump.ToggleState;
            SModule_Airjump.Content = GUIExtensions.GetBoolStateText(Module.AirJump.ToggleState);
        }

        private void SModule_NoFall_Click(object sender, RoutedEventArgs e)
        {
            Module.NoFall.ToggleState = !Module.NoFall.ToggleState;
            SModule_NoFall.Content = GUIExtensions.GetBoolStateText(Module.NoFall.ToggleState);
        }
        private void SModule_Instabreak_Click(object sender, RoutedEventArgs e)
        {
            Module.Instabreak.ToggleState = !Module.Instabreak.ToggleState;
            SModule_Instabreak.Content = GUIExtensions.GetBoolStateText(Module.Instabreak.ToggleState);
        }
        private void SModule_Reach_Click(object sender, RoutedEventArgs e)
        {
            Module.Reach.ToggleState = !Module.Reach.ToggleState;
            SModule_Reach.Content = GUIExtensions.GetBoolStateText(Module.Reach.ToggleState);
        }
        private void SModule_NoSwing_Click(object sender, RoutedEventArgs e)
        {
            Module.NoSwing.ToggleState = !Module.NoSwing.ToggleState;
            SModule_NoSwing.Content = GUIExtensions.GetBoolStateText(Module.NoSwing.ToggleState);
        }
        private void SModule_Coords_Click(object sender, RoutedEventArgs e)
        {
            Module.Coords.ToggleState = !Module.Coords.ToggleState;
            SModule_Coords.Content = GUIExtensions.GetBoolStateText(Module.Coords.ToggleState);
        }
        private void SModule_Speed_Click(object sender, RoutedEventArgs e)
        {
            Module.Speed.ToggleState = !Module.Speed.ToggleState;
            SModule_Speed.Content = GUIExtensions.GetBoolStateText(Module.Speed.ToggleState);
        }
        private void SModule_AutoSprint_Click(object sender, RoutedEventArgs e)
        {
            Module.AutoSprint.ToggleState = !Module.AutoSprint.ToggleState;
            SModule_AutoSprint.Content = GUIExtensions.GetBoolStateText(Module.AutoSprint.ToggleState);
        }
        private void SModule_KillYourSelf_Click(object sender, RoutedEventArgs e)
        {
            Module.KillYourSelf.ToggleState = !Module.KillYourSelf.ToggleState;
            SModule_KillYourSelf.Content = GUIExtensions.GetBoolStateText(Module.KillYourSelf.ToggleState);
        }
        private void SModule_Phase_Click(object sender, RoutedEventArgs e)
        {
            Module.Phase.ToggleState = !Module.Phase.ToggleState;
            SModule_Phase.Content = GUIExtensions.GetBoolStateText(Module.Phase.ToggleState);
        }
        private void SModule_Noclip_Click(object sender, RoutedEventArgs e)
        {
            Module.Noclip.ToggleState = !Module.Noclip.ToggleState;
            SModule_Noclip.Content = GUIExtensions.GetBoolStateText(Module.Noclip.ToggleState);
        }
        private void SModule_Autoclicker_Click(object sender, RoutedEventArgs e)
        {
            Module.Autoclicker.ToggleState = !Module.Autoclicker.ToggleState;
            SModule_Autoclicker.Content = GUIExtensions.GetBoolStateText(Module.Autoclicker.ToggleState);
        }
        private void SModule_AnvilCost_Click(object sender, RoutedEventArgs e)
        {
            Module.AnvilCost.ToggleState = !Module.AnvilCost.ToggleState;
            SModule_AnvilCost.Content = GUIExtensions.GetBoolStateText(Module.AnvilCost.ToggleState);
        }
        private void SModule_HighJump_Click(object sender, RoutedEventArgs e)
        {
            Module.HighJump.ToggleState = !Module.HighJump.ToggleState;
            SModule_HighJump.Content = GUIExtensions.GetBoolStateText(Module.HighJump.ToggleState);
        }
        private void SModule_StickyGround_Click(object sender, RoutedEventArgs e)
        {
            Module.StickyGround.ToggleState = !Module.StickyGround.ToggleState;
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.StickyGround.ToggleState);
        }
        private void SModule_AirWalk_Click(object sender, RoutedEventArgs e)
        {
            Module.AirWalk.ToggleState = !Module.AirWalk.ToggleState;
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.AirWalk.ToggleState);
        }
    }
}
