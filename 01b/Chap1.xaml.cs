using System;
using System.Windows;
using System.Windows.Controls;

namespace _01b
{
    /// <summary>
    /// Chap1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chap1 : Page
    {
        public Chap1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // START 버튼 클릭 시 동작 정의
            NavigationService.Navigate(new StartPage());
        }

        private void Chapter1Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 1 버튼 클릭 시 동작 정의
            NavigationService.Navigate(new Chap1());
        }

        private void Chapter2Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 2 버튼 클릭 시 동작 정의
            NavigationService.Navigate(new Chap2());
        }

        private void Chapter3Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 3 버튼 클릭 시 동작 정의
            NavigationService.Navigate(new Chap3());
        }

        private void Chapter4Button_Click(object sender, RoutedEventArgs e)
        {
            // Chapter 4 버튼 클릭 시 동작 정의
            NavigationService.Navigate(new Chap4());
        }
    }
}
