﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace 账号服务器
{
	internal static class Program
	{
		private static Mutex myMutex;

		[STAThread]
		private static void Main()
		{
			myMutex = new Mutex(initiallyOwned: false, "CY_LoginServer_Mutex", out var createdNew);
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(defaultValue: false);
				Application.Run(new 主窗口());
			}
			else
			{
				MessageBox.Show("服务器已经在运行中");
				Environment.Exit(0);
			}
		}
	}
}
