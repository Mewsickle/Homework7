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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                MessageBox.Show("You died!");
                userNumber = 0;
                userCount = 0;
                UpdateState(userNumber, rnd.Next(50));
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

        private void lblClickCount_Click(object sender, EventArgs e)
        {

        }

        private void lblComputerNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
