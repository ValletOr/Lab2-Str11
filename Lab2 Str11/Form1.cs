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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class Logic
    {
        public static string Execution(string word1, string word2)
        {
            string outMessage = "", buffer = "";
            bool trigger = false;

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
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        trigger = true;
                        outMessage += "да";
                        break;
                    }

                }
                if (!trigger)
                {
                    outMessage += "нет";
                }
                if (i != word1.Length - 1)
                {
                    outMessage += " ";
                }
            }

            return outMessage;
        }
    }
}
