﻿using NetView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NetView.View
{
    /// <summary>
    /// uc_VarMonitor.xaml 的交互逻辑
    /// </summary>
    public partial class UC_VarMonitor : UserControl
    {
        public event EventHandler OnStartMonitorEventHandler;
        public event EventHandler OnStopMonitorEventHandler;
        public event EventHandler OnModifyValueEventHandler;
        public UC_VarMonitor()
        {
            InitializeComponent();
            //VarCollect.Add(new MonitorVarModel());
            //VarCollect.Add(new MonitorVarModel() { IoType = Definations.EnumModuleIOType.OUT });
            //VarCollect.Add(new MonitorVarModel() {  IoType=Definations.EnumModuleIOType.OUT});
            //VarCollect.Add(new MonitorVarModel());
            //VarCollect.Add(new MonitorVarModel() { IoType = Definations.EnumModuleIOType.OUT });
            //root.Background
        } 
        public ObservableCollection<MonitorVarModel> VarCollect { get; set; } = new ObservableCollection<MonitorVarModel>();
        
       

        private void StartMonitor_Click(object sender, RoutedEventArgs e)
        {
            OnStartMonitorEventHandler?.Invoke(this,null);
        }

        private void StopMonitor_Click(object sender, RoutedEventArgs e)
        {
            OnStopMonitorEventHandler?.Invoke(this, null);
        }

        private void ModifyValue_Click(object sender, RoutedEventArgs e)
        {
            OnModifyValueEventHandler?.Invoke(this, null);
        }
    }
}
