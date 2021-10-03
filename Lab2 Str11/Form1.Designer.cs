
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // word1Box
            // 
            this.word1Box.Location = new System.Drawing.Point(13, 56);
            this.word1Box.Name = "word1Box";
            this.word1Box.Size = new System.Drawing.Size(315, 27);
            this.word1Box.TabIndex = 0;
            this.word1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.word1Box_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первое слово";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второе слово";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // word2Box
            // 
            this.word2Box.Location = new System.Drawing.Point(13, 126);
            this.word2Box.Name = "word2Box";
            this.word2Box.Size = new System.Drawing.Size(313, 27);
            this.word2Box.TabIndex = 2;
            this.word2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.word2Box_KeyPress);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(334, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 97);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверить!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Формулировка задания";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(593, 50);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(169, 176);
            this.resultBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 251);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultBox;
    }
}

