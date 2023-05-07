using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using WinRT.Interop;

namespace Workplan
{
    public sealed partial class MainWindow : Window
    {
        private AppWindow m_AppWindow;

        private List<string> ItemsSource { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
            m_AppWindow = GetAppWindowForCurrentWindow();
            m_AppWindow.Title = "Workplan";

            ItemsSource = new List<string>();
            for (int i = 0; i < 10; i++) {
                ItemsSource.Add("Project Name");
            }
        }

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(wndId);
        }
    }
}