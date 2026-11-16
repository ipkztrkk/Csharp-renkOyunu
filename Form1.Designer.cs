namespace RenkOyunu_gorselprogramlama
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
            btn_1 = new Button();
            btn_6 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            label1 = new Label();
            lbl_hamleSayisi = new Label();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.Location = new Point(229, 93);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(94, 91);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(454, 205);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(94, 91);
            btn_6.TabIndex = 1;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(454, 311);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(94, 91);
            btn_9.TabIndex = 2;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(345, 311);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(94, 91);
            btn_8.TabIndex = 3;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(229, 311);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(94, 91);
            btn_7.TabIndex = 4;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(345, 205);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(94, 91);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(229, 205);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(94, 91);
            btn_4.TabIndex = 6;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(454, 93);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(94, 91);
            btn_3.TabIndex = 7;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(345, 93);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(94, 91);
            btn_2.TabIndex = 8;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 36);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 9;
            label1.Text = "Hamle Sayısı :";
            // 
            // lbl_hamleSayisi
            // 
            lbl_hamleSayisi.AutoSize = true;
            lbl_hamleSayisi.Location = new Point(357, 36);
            lbl_hamleSayisi.Name = "lbl_hamleSayisi";
            lbl_hamleSayisi.Size = new Size(17, 20);
            lbl_hamleSayisi.TabIndex = 10;
            lbl_hamleSayisi.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_hamleSayisi);
            Controls.Add(label1);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Controls.Add(btn_4);
            Controls.Add(btn_5);
            Controls.Add(btn_7);
            Controls.Add(btn_8);
            Controls.Add(btn_9);
            Controls.Add(btn_6);
            Controls.Add(btn_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_1;
        private Button btn_6;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Label label1;
        private Label lbl_hamleSayisi;
    }
}
