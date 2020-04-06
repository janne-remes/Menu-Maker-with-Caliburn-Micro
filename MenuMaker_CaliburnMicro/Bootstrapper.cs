﻿using Caliburn.Micro;
using MenuMaker_CaliburnMicro.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MenuMaker_CaliburnMicro
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
