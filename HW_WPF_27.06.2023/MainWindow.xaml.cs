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
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace HW_WPF_27._06._2023
{
    public partial class MainWindow : Window
    {
        private bool isClick = false;
        private Point oldPoint, newPoint;
        private double currentX, currentY;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Square_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            oldPoint = e.GetPosition(this);
            isClick = true;
            square.CaptureMouse();
        }

        private void Square_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isClick = false;
            square.ReleaseMouseCapture();
        }

        private void Square_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                newPoint = e.GetPosition(this);

                currentX = Double.Parse(txtX.Text) + (newPoint.X - oldPoint.X);
                currentY = Double.Parse(txtY.Text) + (newPoint.Y - oldPoint.Y);

                txtX.Text = currentX.ToString();
                txtY.Text = currentY.ToString();

                oldPoint = newPoint;
            }
        }
    }
}
