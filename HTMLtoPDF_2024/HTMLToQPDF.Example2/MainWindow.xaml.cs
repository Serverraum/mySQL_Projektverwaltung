﻿using QuestPDF.Infrastructure;
using System.Windows;

namespace HTMLToQPDF.Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            QuestPDF.Settings.License = LicenseType.Community; 
            InitializeComponent();
        }
    }
}