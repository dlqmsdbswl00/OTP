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
    /// Chap2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chap2 : Page
    {
        private int currentQuizIndex = 0;
        private readonly string[] questions = {
            "Q1. 오픈소스 사용 시 주의가 필요한 고려사항 3가지는?",
            "Q2. 컴퓨터프로그램저작물이 보호 받는 지식재산권 유형4가지는?",
            "Q3. 오픈소스와 결합·연결되었을 경우,\r\n연결된 소스코드까지 공개하는 오픈소스 라이선스 패밀리 유형은? (ex: GPL2.0)",
            "Q4. 다음 저작권 표시의 의미는? : CC-BY-NC-SA",
            "Q5. CodeEye와 같은 점검 도구를 통해 도출된 유사율을 기반으로 오픈소스 라이선스를 결정하는 과정을 무엇이라고 할까요?"
        };
        private readonly string[] answers = {
            "지식재산권, 라이선스, 보안취약점",
            "저작권, 특허권, 상표권, 영업비밀",
            "Strong Reciprocal License",
            "저작권표시, 상업적사용금지,\r\n동일라이선스로자유로운사용가능",
            "오픈소스라이선스식별과정"
        };
        public Chap2()
        {
            InitializeComponent();
            QuizQuestion.Text = questions[currentQuizIndex];
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (AnswerTextBox.Text.Trim().Equals(answers[currentQuizIndex], System.StringComparison.OrdinalIgnoreCase))
            {
                currentQuizIndex++;
                if (currentQuizIndex < questions.Length)
                {
                    QuizQuestion.Text = questions[currentQuizIndex];
                    AnswerTextBox.Text = "";
                    FeedbackTextBlock.Text = "";
                }
                else
                {
                    QuizQuestion.Text = "모든 퀴즈를 완료했습니다!";
                    AnswerTextBox.Visibility = Visibility.Collapsed;
                    SubmitButton.Visibility = Visibility.Collapsed;
                    FeedbackTextBlock.Text = "";
                }
            }
            else
            {
                FeedbackTextBlock.Text = "정답이 아닙니다. 다시 시도하세요.";
            }
        }
    }
}

