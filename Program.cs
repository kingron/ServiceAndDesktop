﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAndDesktop
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                MainForm FrmMain = new MainForm();
                if (!FrmMain.IsDisposed)
                {
                    Application.Run(FrmMain);
                }
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new svrDemo()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
