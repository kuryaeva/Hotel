﻿using System;
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

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Sistema_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();



        }

        private void PasswordHyperlink_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
