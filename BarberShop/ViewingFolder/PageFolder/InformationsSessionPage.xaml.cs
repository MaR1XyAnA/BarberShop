﻿using BarberShop.ContentFolder.ClassFolder;
using BarberShop.ViewingFolder.WindowsFolder;
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

namespace BarberShop.ViewingFolder.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для InformationsSessionPage.xaml
    /// </summary>
    public partial class InformationsSessionPage : Page
    {
        public InformationsSessionPage()
        {
            InitializeComponent();
        }

        private void SessionsInfoButton_Click(object sender, RoutedEventArgs e)
        {
            QueueWindows queueWindows = new QueueWindows();
            queueWindows.Show();
        }
    }
}
