﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OxtaPark
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static readonly Entities.OxtaPark3Entities Bd = new Entities.OxtaPark3Entities();
    }
}
