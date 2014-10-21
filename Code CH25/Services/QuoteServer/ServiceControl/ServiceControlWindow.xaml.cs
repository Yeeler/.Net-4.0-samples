﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceProcess;

namespace Wrox.ProCSharp.WinServices
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ServiceControlWindow : Window
    {
        public ServiceControlWindow()
        {
            InitializeComponent();
            RefreshServiceList();
        }

        protected void OnServiceCommand(object sender, RoutedEventArgs e)
        {
            Cursor oldCursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.Wait;
                ServiceControllerInfo si =
                       (ServiceControllerInfo)listBoxServices.SelectedItem;
                if (sender == this.buttonStart)
                {
                    si.Controller.Start();
                    si.Controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
                else if (sender == this.buttonStop)
                {
                    si.Controller.Stop();
                    si.Controller.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
                else if (sender == this.buttonPause)
                {
                    si.Controller.Pause();
                    si.Controller.WaitForStatus(ServiceControllerStatus.Paused, TimeSpan.FromSeconds(10));
                }
                else if (sender == this.buttonContinue)
                {
                    si.Controller.Continue();
                    si.Controller.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
                int index = listBoxServices.SelectedIndex;
                RefreshServiceList();
                listBoxServices.SelectedIndex = index;
            }
            catch (System.ServiceProcess.TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Timeout Service Controller", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(String.Format("{0} {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : String.Empty),
                    "Error Service Controller", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                this.Cursor = oldCursor;
            }
        }


        protected void RefreshServiceList()
        {
            ServiceController[] services = ServiceController.GetServices();

            Array.Sort(services, (s1, s2) => s1.DisplayName.CompareTo(s2.DisplayName));

            this.DataContext =
                Array.ConvertAll(services, controller => new ServiceControllerInfo(controller));
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void OnRefresh(object sender, RoutedEventArgs e)
        {
            RefreshServiceList();
        }
    }
}