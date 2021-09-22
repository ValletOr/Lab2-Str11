
namespace Lab2_Str11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.word1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.word2Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // word1Box
            // 
            this.word1Box.Location = new System.Drawing.Point(29, 53);
            this.word1Box.Name = "word1Box";
            this.word1Box.Size = new System.Drawing.Size(152, 27);
            this.word1Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второе слово";
            // 
            // word2Box
            // 
            this.word2Box.Location = new System.Drawing.Point(29, 86);
            this.word2Box.Name = "word2Box";
            this.word2Box.Size = new System.Drawing.Size(152, 27);
            this.word2Box.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(333, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверить!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Проверка букв первого слова на присутствие во втором слове.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 128);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.word2Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word1Box);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2. Задание на строки. Вариант 11.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox word2Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

