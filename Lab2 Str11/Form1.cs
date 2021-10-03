using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Str11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Вводим значения с прошлого запуска
            word1Box.Text = Properties.Settings.Default.word1Box;
            word2Box.Text = Properties.Settings.Default.word2Box;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранение введённых значений.
            Properties.Settings.Default.word1Box = word1Box.Text;
            Properties.Settings.Default.word2Box = word2Box.Text;
            Properties.Settings.Default.Save();

            //Проверка на пустоту в первом слове.
            if (string.IsNullOrEmpty(word1Box.Text))
            {
                MessageBox.Show("Первое слово не введено, невозможно вывести результат.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                resultBox.Text = Logic.Execution(word1Box.Text, word2Box.Text);
                word1Box.Text = "";
                word2Box.Text = "";
            }
        }

        private void word1Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                word2Box.Focus();
            }
        }

        private void word2Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
                word1Box.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны два слова. Для каждой буквы первого слова определить, входит ли она во второе слово. Повторяющиеся буквы первого слова не рассматривать. Например, если заданные слова процессор и информация, то для букв первого из них ответом должно быть: нет да да да нет нет.");
        }
    }

    public static class Logic
    {
        public static string Execution(string word1, string word2)
        {
            string outMessage = "", buffer = "";
            bool trigger = false;
            int j;

            //Приведение букв в словах к одному регистру (нижнему)
            word1 = word1.ToLower();
            word2 = word2.ToLower();

            //Чистка первого слова от повторяющихся букв
            for (int i = 0; i < word1.Length; i++)
            {
                if (!buffer.Contains(word1[i]))
                {
                    buffer += word1[i];
                }
            }
            word1 = buffer;

            //Основной расчёт
            for (int i = 0; i < word1.Length; i++)
            {
                trigger = false;
                j = 0;
                outMessage += word1[i]+" - ";
                while ((trigger != true) && (j < word2.Length))
                {
                    if (word1[i] == word2[j])
                    {
                        trigger = true;
                        outMessage += "да";
                    }
                    j++;
                }
                if (!trigger)
                {
                    outMessage += "нет";
                }
                if (i != word1.Length - 1)
                {
                    outMessage += "\r\n";
                }
            }

            //Возврат значения.
            return outMessage;
        }
    }
}
