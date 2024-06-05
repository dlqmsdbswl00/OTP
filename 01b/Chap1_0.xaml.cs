using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01b
{
    /// <summary>
    /// Chap1_0.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chap1_0 : Page
    {
        public Chap1_0()
        {
            InitializeComponent();
        }


        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            // 이전 페이지로 이동
            // 예를 들어 Chap0 페이지가 있다면:
            // Chap0 newPage = new Chap0();
            // NavigationService.Navigate(newPage);
            // 이런 식으로 페이지를 변경합니다.
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // 다음 페이지로 이동
            // 예를 들어 Chap2 페이지가 있다면:
            // Chap2 newPage = new Chap2();
            // NavigationService.Navigate(newPage);
            // 이런 식으로 페이지를 변경합니다.

            Chap1_1 newPage = new Chap1_1();
            NavigationService.Navigate(newPage);
        }
    }
}
