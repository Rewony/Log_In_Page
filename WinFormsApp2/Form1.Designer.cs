namespace WinFormsApp2
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
            this.tboxka = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btngiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lablsonuc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsehir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxka
            // 
            this.tboxka.Location = new System.Drawing.Point(31, 84);
            this.tboxka.Name = "tboxka";
            this.tboxka.Size = new System.Drawing.Size(125, 27);
            this.tboxka.TabIndex = 0;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(31, 135);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(125, 27);
            this.textpass.TabIndex = 1;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOŞ GELDİNİZ LÜTFEN GİRİŞ YAPINIZ";
            // 
            // Btngiris
            // 
            this.Btngiris.Location = new System.Drawing.Point(31, 239);
            this.Btngiris.Name = "Btngiris";
            this.Btngiris.Size = new System.Drawing.Size(94, 29);
            this.Btngiris.TabIndex = 3;
            this.Btngiris.Text = "Giriş yap";
            this.Btngiris.UseVisualStyleBackColor = true;
            this.Btngiris.Click += new System.EventHandler(this.Btngiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "şifre";
            // 
            // lablsonuc
            // 
            this.lablsonuc.AutoSize = true;
            this.lablsonuc.Location = new System.Drawing.Point(661, 196);
            this.lablsonuc.Name = "lablsonuc";
            this.lablsonuc.Size = new System.Drawing.Size(50, 20);
            this.lablsonuc.TabIndex = 6;
            this.lablsonuc.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "şehir";
            // 
            // labelsehir
            // 
            this.labelsehir.AutoSize = true;
            this.labelsehir.Location = new System.Drawing.Point(31, 389);
            this.labelsehir.Name = "labelsehir";
            this.labelsehir.Size = new System.Drawing.Size(0, 20);
            this.labelsehir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(750, 340);
            this.Controls.Add(this.labelsehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lablsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btngiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.tboxka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tboxka;
        private TextBox textpass;
        private Label label1;
        private Button Btngiris;
        private Label label2;
        private Label label3;
        private Label lablsonuc;
        private ComboBox comboBox1;
        private Label label4;
        private Label labelsehir;
    }
}