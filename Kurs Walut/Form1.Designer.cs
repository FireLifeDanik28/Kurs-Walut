namespace Kurs_Walut
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            FPLN = new RadioButton();
            FTHB = new RadioButton();
            FUAH = new RadioButton();
            FEUR = new RadioButton();
            FUSD = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            TPLN = new RadioButton();
            TTHB = new RadioButton();
            TUAH = new RadioButton();
            TEUR = new RadioButton();
            TUSD = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Wynik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Kwota";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FPLN);
            groupBox1.Controls.Add(FTHB);
            groupBox1.Controls.Add(FUAH);
            groupBox1.Controls.Add(FEUR);
            groupBox1.Controls.Add(FUSD);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(100, 145);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta 1";
            // 
            // FPLN
            // 
            FPLN.AutoSize = true;
            FPLN.Location = new Point(3, 119);
            FPLN.Name = "FPLN";
            FPLN.Size = new Size(47, 19);
            FPLN.TabIndex = 4;
            FPLN.TabStop = true;
            FPLN.Text = "PLN";
            FPLN.UseVisualStyleBackColor = true;
            // 
            // FTHB
            // 
            FTHB.AutoSize = true;
            FTHB.Location = new Point(3, 94);
            FTHB.Name = "FTHB";
            FTHB.Size = new Size(47, 19);
            FTHB.TabIndex = 3;
            FTHB.TabStop = true;
            FTHB.Text = "THB";
            FTHB.UseVisualStyleBackColor = true;
            // 
            // FUAH
            // 
            FUAH.AutoSize = true;
            FUAH.Location = new Point(3, 69);
            FUAH.Name = "FUAH";
            FUAH.Size = new Size(50, 19);
            FUAH.TabIndex = 2;
            FUAH.TabStop = true;
            FUAH.Text = "UAH";
            FUAH.UseVisualStyleBackColor = true;
            // 
            // FEUR
            // 
            FEUR.AutoSize = true;
            FEUR.Location = new Point(3, 44);
            FEUR.Name = "FEUR";
            FEUR.Size = new Size(46, 19);
            FEUR.TabIndex = 1;
            FEUR.TabStop = true;
            FEUR.Text = "EUR";
            FEUR.UseVisualStyleBackColor = true;
            // 
            // FUSD
            // 
            FUSD.AutoSize = true;
            FUSD.Location = new Point(3, 19);
            FUSD.Name = "FUSD";
            FUSD.Size = new Size(47, 19);
            FUSD.TabIndex = 0;
            FUSD.TabStop = true;
            FUSD.Text = "USD";
            FUSD.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(228, 65);
            button1.Name = "button1";
            button1.Size = new Size(61, 138);
            button1.TabIndex = 7;
            button1.Text = "Przelicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TPLN);
            groupBox2.Controls.Add(TTHB);
            groupBox2.Controls.Add(TUAH);
            groupBox2.Controls.Add(TEUR);
            groupBox2.Controls.Add(TUSD);
            groupBox2.Location = new Point(122, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(100, 145);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waluta 2";
            // 
            // TPLN
            // 
            TPLN.AutoSize = true;
            TPLN.Location = new Point(3, 119);
            TPLN.Name = "TPLN";
            TPLN.Size = new Size(47, 19);
            TPLN.TabIndex = 4;
            TPLN.TabStop = true;
            TPLN.Text = "PLN";
            TPLN.UseVisualStyleBackColor = true;
            // 
            // TTHB
            // 
            TTHB.AutoSize = true;
            TTHB.Location = new Point(3, 94);
            TTHB.Name = "TTHB";
            TTHB.Size = new Size(47, 19);
            TTHB.TabIndex = 3;
            TTHB.TabStop = true;
            TTHB.Text = "THB";
            TTHB.UseVisualStyleBackColor = true;
            // 
            // TUAH
            // 
            TUAH.AutoSize = true;
            TUAH.Location = new Point(3, 69);
            TUAH.Name = "TUAH";
            TUAH.Size = new Size(50, 19);
            TUAH.TabIndex = 2;
            TUAH.TabStop = true;
            TUAH.Text = "UAH";
            TUAH.UseVisualStyleBackColor = true;
            // 
            // TEUR
            // 
            TEUR.AutoSize = true;
            TEUR.Location = new Point(3, 44);
            TEUR.Name = "TEUR";
            TEUR.Size = new Size(46, 19);
            TEUR.TabIndex = 1;
            TEUR.TabStop = true;
            TEUR.Text = "EUR";
            TEUR.UseVisualStyleBackColor = true;
            // 
            // TUSD
            // 
            TUSD.AutoSize = true;
            TUSD.Location = new Point(3, 19);
            TUSD.Name = "TUSD";
            TUSD.Size = new Size(47, 19);
            TUSD.TabIndex = 0;
            TUSD.TabStop = true;
            TUSD.Text = "USD";
            TUSD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 206);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton FUAH;
        private RadioButton FEUR;
        private RadioButton FUSD;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private RadioButton FTHB;
        private RadioButton FPLN;
        private GroupBox groupBox2;
        private RadioButton TPLN;
        private RadioButton TTHB;
        private RadioButton TUAH;
        private RadioButton TEUR;
        private RadioButton TUSD;
    }
}
