﻿using System.Windows;
using System.Windows.Controls;

namespace FileManager.Views
{
    /// <summary>
    /// Interaction logic for <see cref="MainWindow"/>
    /// </summary>
    public partial class MainWindow : SystemMenuWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.MainWindowViewModel();
        }
    }
}
