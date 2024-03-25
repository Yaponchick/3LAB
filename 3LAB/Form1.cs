/*���������� �����, ���������� ���������� � ������������.

��������
���������
���������
������� ���� ������
���������� �����
��������� ���� ������*/
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

       
        private void onValueChanged(object sender, EventArgs e)
        {
            if (IsNumeric(txtFirst.Text) && IsNumeric(txtSecond.Text) && IsNumeric(txtThird.Text) && IsNumeric(txtFourth.Text))
            {
                Calculate();
            }
        }


        private bool IsNumeric(string value)
        {
                return double.TryParse(value, out _);

        }





        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);
                var ThirdValue = double.Parse(txtThird.Text);
                var FourthValue = double.Parse(txtFourth.Text);

/*              bool Valid1= Regex.IsMatch(firstValue.ToString(), @"^[0-9]*(?:\.[0-9]*)?$");
                bool Valid2 = Regex.IsMatch(secondValue.ToString(), @"^[0-9]*(?:\.[0-9]*)?$");
                bool Valid3 = Regex.IsMatch(ThirdValue.ToString(), @"^[0-9]*(?:\.[0-9]*)?$");
                bool Valid4 = Regex.IsMatch(FourthValue.ToString(), @"^[0-9]*(?:\.[0-9]*)?$");

                if(Valid1 || Valid2 || Valid3 || Valid4) // @"^[a-zA-Z�-��-�]+$"
                {
                    throw new FormatException();
                }*/

                // �������� �� ����������� ���� ��� �����������
                if (secondValue == 0 || FourthValue == 0 || firstValue == 0 || ThirdValue == 0)
                {
                    MessageBox.Show("����������� ��� ��������� �� ����� ���� ����� ����!");
                    return;
                }

                if(firstValue >= secondValue)
                {
                    MessageBox.Show("��������� ������ ���� ������ �����������");
                    txtFirst.Text = "";
                    txtResult.Text = "";
                    return;
                }
                if (ThirdValue >= FourthValue) 
                {
                    MessageBox.Show("��������� ������ ���� ������ �����������");
                    txtThird.Text = "";
                    txtResult.Text = "";
                    return;
                }

  
                // �� ��������� �������� ������� ���������� ������ ������ Length 
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
                MessageBox.Show("������ ������� ������");
            }
        }
    }
}

//�������� ��������, ��������� ���, �������� �����, ������� �����
