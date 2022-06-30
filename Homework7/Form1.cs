using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
  Домашнее задание
1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный
класс Stack.
Вся логика игры должна быть реализована в классе с удвоителем.
2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от
1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит,
больше или меньше загаданное число введенного.
a) Для ввода данных от человека используется элемент TextBox;
б) **Реализовать отдельную форму c TextBox для ввода числа

Студент Ким Алексей
*/

namespace Homework7
{
    public partial class Удвоитель : Form
    {
        Random rnd = new Random();
        int computerNumber;
        int userNumber;
        double userCount;
        public Удвоитель()
        {
            InitializeComponent();
            UpdateState(userNumber, rnd.Next(50));
            UpdateState(userCount);

        }
        private void UpdateState(int userNumber)
        {
            lblUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateState(double userCount)
        {
            lblClickCount.Text = $"Количество действий: {userCount}";

        }
        private void UpdateState(int userNumber, int computerNumber)
        {
            UpdateState(userNumber);
            this.computerNumber = computerNumber;

            lblComputerNumber.Text = $"Получите число: {computerNumber}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UpdateState(++userCount);
            UpdateState(++userNumber);
            if (userNumber ==computerNumber)
            {
                CheckWin();
            }

            else if(computerNumber < userNumber)
            {
                MessageBox.Show("Вы проиграли!");
                if (MessageBox.Show("Хотите сыграть еще?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

      
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateState(userNumber *= 2);
            UpdateState(++userCount);

            if (userNumber == computerNumber)
            {
                CheckWin();

            }

            else if (computerNumber < userNumber)
            {
                MessageBox.Show("Вы проиграли!");
                if (MessageBox.Show("Хотите сыграть еще?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            userCount = 0;
            UpdateState(userNumber, rnd.Next(50));
            ShowUI();
            MessageBox.Show($"Получите число: {lblComputerNumber}", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void ShowUI()
        {
            btnReset.Visible = true;
            btnCommand1.Visible = true;
            btnCommand2.Visible = true;
            lblClickCount.Visible = true;
            lblComputerNumber.Visible = true;
            lblUserNumber.Visible = true;
            buttonClose.Visible = false;
            buttonNewGame.Visible = false;
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show("Победа!", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Хотите сыграть еще?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            userNumber = 0;
            userCount = 0;
            UpdateState(userNumber, rnd.Next(50));
            ShowUI();
            MessageBox.Show($"Получите число: {lblComputerNumber}", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно точно хотите выйти?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"Бяка", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Удвоитель_Load(object sender, EventArgs e)
        {

        }

        private void угадайЧислоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            УгадайЧисло gameSwap1 = new УгадайЧисло();
            gameSwap1.ShowDialog();

        }
    }
}
