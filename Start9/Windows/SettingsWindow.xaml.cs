﻿using System.Windows;
using Start9.Api.Plex;
using Start9.Api.Tools;
using System.Windows.Interop;
using System;

namespace Start9.Windows
{
	/// <summary>
	///     Interaction logic for SettingsWindow.xaml
	/// </summary>
	public partial class SettingsWindow : PlexWindow
	{
		public SettingsWindow()
		{
			InitializeComponent();
			MainTools.SettingsWindow = this;
		}

		void TitleBarCheckBox_Checked(object sender, RoutedEventArgs e)
		{
			ShowTitleBar = true;
		}

		void TitleBarCheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			ShowTitleBar = false;
		}

		void ToolBarCheckBox_Checked(object sender, RoutedEventArgs e)
		{
			ShowToolBar = true;
		}

		void ToolBarCheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			ShowToolBar = false;
		}

		void FooterCheckBox_Checked(object sender, RoutedEventArgs e)
		{
			ShowFooter = true;
		}

		void FooterCheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			ShowFooter = false;
		}

        private void ShowThumbnailButton_Click(object sender, RoutedEventArgs e)
        {
            DwmTools.GetThumbnail(WinApi.FindWindowEx(IntPtr.Zero, IntPtr.Zero, null, "Progman"), ShowThumbnailButton);
        }
    }
}