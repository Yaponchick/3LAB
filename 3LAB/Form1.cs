                    /*Задание*/
/*Правильная дробь, задаваемая числителем и знаменателем.
сложение
вычитание
умножение
деление двух дробей
сокращение дроби
сравнение двух дробей*/

using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace _3LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        /brief Обработчик события, который вызывается каждый раз, когда значение в одном из текстовых полей изменяется.
        /param sender - объект вызывающий событие. EventArgs e - содержит дополнительные данные о событии.
        */
        private void onValueChanged(object sender, EventArgs e)
        {
            if (IsNumeric(txtFirst.Text) && IsNumeric(txtSecond.Text) && IsNumeric(txtThird.Text) && IsNumeric(txtFourth.Text))
            {
                Calculate();
            }
        }

        /*
        /brief Функция для проверки ввода.
        /param value - введенное число.
        /return Возвращение значения, если оно является числом.
        */
        private bool IsNumeric(string value)
        {
                return double.TryParse(value, out _);
        }
        /*
        /brief Функция проверяет ввод и отвечает за логику выбранного пользователем действия.
        */
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);
                var ThirdValue = double.Parse(txtThird.Text);
                var FourthValue = double.Parse(txtFourth.Text);

                if (secondValue == 0 || FourthValue == 0 || firstValue == 0 || ThirdValue == 0)
                {
                    MessageBox.Show("Знаменатель или числитель не может быть равен нулю!");
                    return;
                }

                if(firstValue >= secondValue)
                {
                    MessageBox.Show("Числитель должен быть меньше знаменателя");
                    txtFirst.Text = "";
                    txtResult.Text = "";
                    return;
                }
                if (ThirdValue >= FourthValue) 
                {
                    MessageBox.Show("Числитель должен быть меньше знаменателя");
                    txtThird.Text = "";
                    txtResult.Text = "";
                    return;
                }

  
                // на основании значений создали экземпляры нашего класса Length 
                var firstLength = new Length(firstValue, secondValue);
                var secondLength = new Length(ThirdValue, FourthValue);

                string sumLengthStr;

                switch (comboBox1.Text)
                {
                    case "+":
                        var sumLength = firstLength + secondLength;
                        txtResult.Text = sumLength.Remains();
                        break;
                    case "-":
                        var minusLength = firstLength - secondLength;
                        txtResult.Text = minusLength.Remains();
                        break;
                    case "*":
                        var multiplyLength = firstLength * secondLength;
                        txtResult.Text = multiplyLength.Remains();
                        break;
                    case "/":
                        var divideLength = firstLength / secondLength;
                        txtResult.Text = divideLength.Remains();
                        break;
                    case "<":
                        sumLengthStr = (firstLength < secondLength).ToString();
                        if (firstValue / secondValue < ThirdValue / FourthValue) 
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " < " + ThirdValue + "/" + FourthValue;
                            txtResult.Text = sumLengthStr;
                        }
                        else
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " > " + ThirdValue + "/" + FourthValue; 
                            txtResult.Text = sumLengthStr;
                        }
                        if (firstValue / secondValue == ThirdValue / FourthValue)
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " = " + ThirdValue + "/" + FourthValue;
                            txtResult.Text = sumLengthStr;
                        }
                        break;

                    case ">":
                        sumLengthStr = (firstLength > secondLength).ToString();
                        if (firstValue / secondValue > ThirdValue / FourthValue)
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " > " + ThirdValue + "/" + FourthValue;
                            txtResult.Text = sumLengthStr;
                        }
                        else
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " < " + ThirdValue + "/" + FourthValue;
                            txtResult.Text = sumLengthStr;
                        }
                        if (firstValue / secondValue == ThirdValue / FourthValue)
                        {
                            sumLengthStr = firstValue + "/" + secondValue + " = " + ThirdValue + "/" + FourthValue;
                            txtResult.Text = sumLengthStr;
                        }
                        break;
                    default:
                    
                        txtResult.Text = new Length(0, 0).Verbose();
                        break;
                }
              
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}