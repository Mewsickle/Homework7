using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class УгадайЧисло : Form
    {
        Random rnd = new Random();
        int computerNumber;
        int userNumber;
        double userCount;

        public УгадайЧисло()
        {
            InitializeComponent();
            UpdateState(userNumber, rnd.Next(100));
            UpdateState(userCount);
        }

        private void UpdateState(int userNumber)
        {
            lblUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateState(double userCount)
        {
            lblUserCount.Text = $"Количество попыток: {userCount}";

        }

        private void UpdateState(int userNumber, int computerNumber)
        {
            UpdateState(userNumber);
            this.computerNumber = computerNumber;

            lblComputerNumber.Text = $"Получите число: {computerNumber}";
        }

        private void ShowUI()
        {
            txtBox1.Visible = true;
            btnExit.Visible = false;
            btnStart.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            userCount = 0;
            UpdateState(userNumber, rnd.Next(100));
            ShowUI();
            MessageBox.Show($"Угадайте число от 1 до 100!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно точно хотите выйти?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Бяка", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                }
                else
                {


                }

            }
            else
            {


            }
        }

       
        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Победа!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Хотите сыграть еще?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    userCount = 0;
                    UpdateState(userNumber, rnd.Next(100));

                }
                else
                {
                    Close();

                }

            }
        }



        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            //UpdateState(++userCount);
            //userNumber = Int32.Parse(txtBox1.Text);
            //CheckWin();

            //if (userNumber < computerNumber)
            //{
            //    MessageBox.Show("ваше число меньше!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (userNumber > computerNumber)
            //{
            //    MessageBox.Show("ваше число ,больше!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //else if (userCount > 8)
            //{
            //    MessageBox.Show("Вы проиграли!");
            //    if (MessageBox.Show("Хотите сыграть еще?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        userNumber = 0;
            //        userCount = 0;
            //        UpdateState(userNumber, rnd.Next(50));

            //    }
            //    else
            //    {
            //        Close();
            //    }
            //}
        }

        // не реагирует на Enter. Не знаю что не так
        private void txtBox1_KeyDown(object sender, KeyEventArgs e)

        {



            if (e.KeyCode == Keys.Enter)
            {


                UpdateState(++userCount);
                userNumber = Int32.Parse(txtBox1.Text);
                CheckWin();

                if (userNumber < computerNumber)
                {
                    MessageBox.Show("ваше число меньше!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userNumber > computerNumber)
                {
                    MessageBox.Show("ваше число ,больше!", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (userCount > 8)
                {
                    MessageBox.Show("Вы проиграли!");
                    if (MessageBox.Show("Хотите сыграть еще?", "Угадай число", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userNumber = 0;
                        userCount = 0;
                        UpdateState(userNumber, rnd.Next(50));

                    }
                    else
                    {
                        Close();
                    }
                }

            }

        }


    }
}
