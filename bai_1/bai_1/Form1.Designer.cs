﻿namespace bai_1
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhập số:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 47);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(745, 74);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 3;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(34, 107);
            button2.Name = "button2";
            button2.Size = new Size(339, 58);
            button2.TabIndex = 4;
            button2.Text = "Tăng mỗi phần tử lên 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 209);
            button3.Name = "button3";
            button3.Size = new Size(339, 58);
            button3.TabIndex = 5;
            button3.Text = "Chọn số chẵn đầu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(34, 307);
            button4.Name = "button4";
            button4.Size = new Size(339, 58);
            button4.TabIndex = 6;
            button4.Text = "Chọn số lẻ cuối";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(34, 403);
            button5.Name = "button5";
            button5.Size = new Size(339, 58);
            button5.TabIndex = 7;
            button5.Text = "Xóa phần tử đang chọn";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(34, 500);
            button6.Name = "button6";
            button6.Size = new Size(339, 58);
            button6.TabIndex = 8;
            button6.Text = "Xóa phần tử đầu";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(34, 590);
            button7.Name = "button7";
            button7.Size = new Size(339, 58);
            button7.TabIndex = 9;
            button7.Text = "Xóa phần tử cuối";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(172, 970);
            button8.Name = "button8";
            button8.Size = new Size(916, 58);
            button8.TabIndex = 10;
            button8.Text = "Kết thúc";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(721, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 705);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(115, 219);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(509, 701);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 1085);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private GroupBox groupBox1;
        private ListBox listBox1;
    }
}
