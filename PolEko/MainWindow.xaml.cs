﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace PolEko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddDevice_Click(object sender, RoutedEventArgs e)
        {
          IpPrompt prompt = new(ProcessNewDevice);
          prompt.Show();
        }
        
        private static void ProcessNewDevice(IPAddress ipAddress)
        {
          Device device = new(ipAddress);
          MessageBox.Show($"{device.IpAddress}");
        }
    }
}