using System;
using System.Windows;
using System.Windows.Controls;

namespace _01b
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // START 버튼 클릭 시 동작 정의
            MainFrame.Navigate(new StartPage());
        }

        private void Chapter1Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 1 버튼 클릭 시 동작 정의
            MainFrame.Navigate(new Chap1_0());
        }

        private void Chapter2Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 2 버튼 클릭 시 동작 정의
            MainFrame.Navigate(new Chap2());
        }

        private void Chapter3Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 3 버튼 클릭 시 동작 정의
            MainFrame.Navigate(new Chap3());
        }

        private void Chapter4Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 4 버튼 클릭 시 동작 정의
            MainFrame.Navigate(new Chap4());
        }
    }
}
