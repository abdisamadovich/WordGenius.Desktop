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

namespace WordGenius.Desktop.Pages;

/// <summary>
/// Interaction logic for ResultPage.xaml
/// </summary>
public partial class ResultPage : Page
{
    public ResultPage()
    {
        InitializeComponent();
    }

    public void SetData(string correct, string incorrect)
    {
        Yashilchiroq.Text = correct;
        Qizilchiroq.Text = incorrect;
    }
}

