namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label12 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(64, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(260, 224);
            label12.Name = "label12";
            label12.Size = new Size(61, 24);
            label12.TabIndex = 9;
            label12.Text = "label12";
            label12.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(303, 79);
            button2.Name = "button2";
            button2.Size = new Size(65, 37);
            button2.TabIndex = 8;
            button2.Text = "< >";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(144, 212);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(49, 30);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 212);
            label4.Name = "label4";
            label4.Size = new Size(49, 24);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(143, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 30);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 172);
            label3.Name = "label3";
            label3.Size = new Size(51, 24);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ABD Virjin Adaları", "Afganistan", "Almanya", "Amerika Birleşik Devletleri", "Amerikan Samoası", "Andorra", "Angora", "Anguilla", "Antigua ve Barbuda", "Arjantin", "Arnavutluk", "Aruba", "Avustralya", "Avusturya", "Azerbeycan", "Aziz Pierre ve Miquelon", "Bahamalar", "Bahreyn", "Bangladeş", "Barbados", "Belçika", "Belize", "Benin", "Beyaz rusya", "Bhutan", "Birleşik Arap Emirlikleri", "bir tür inek", "Bolivya", "Bosna Hersek", "Botsvana", "Brezilya", "Britanya Virjin Adaları", "Brunei", "Buğdan", "Bulgaristan", "Burkina Faso", "Burundi", "Büyük Britanya", "Cayman adaları", "Cebelitarık", "Cezayir", "Cibuti", "Cocos Adaları", "Cook Adaları", "Curacao", "Çad", "Çek Cumhuriyeti", "Çin", "Danimarka", "Dem. Cum. Kongo", "Doğu Timor", "Dominika", "Dominik Cumhuriyeti", "Ekvador", "Ekvator Ginesi", "Endonezya", "Eritre", "Ermenistan", "Estonya", "Etiyopya", "Falkland", "Faroe Adaları", "Fas", "Fiji", "Fildişi Sahilleri", "Filipinler", "Filistin", "Finlandiya", "Fransa", "Fransız Polinezyası", "Gabon", "Gambiya" });
            comboBox2.Location = new Point(89, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 32);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Ankara", "Bursa", "İzmir", "Antalya", "Diyarbakır", "Gaziantep", "Şanlıurfa", "Trabzon", "Adana", "Konya", "Manisa", "Muğla", "Siirt" });
            comboBox1.Location = new Point(89, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 32);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 116);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(485, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.TitleBar;
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(248, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(89, 175);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(208, 30);
            maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(89, 132);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(208, 30);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(169, 268);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 28);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(89, 270);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 28);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(89, 218);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 30);
            numericUpDown1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 30);
            textBox1.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 270);
            label9.Name = "label9";
            label9.Size = new Size(73, 24);
            label9.TabIndex = 4;
            label9.Text = "Cinsiyet:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 218);
            label8.Name = "label8";
            label8.Size = new Size(43, 24);
            label8.TabIndex = 3;
            label8.Text = "Yaş:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 175);
            label10.Name = "label10";
            label10.Size = new Size(63, 24);
            label10.TabIndex = 2;
            label10.Text = "Tel No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 132);
            label7.Name = "label7";
            label7.Size = new Size(42, 24);
            label7.TabIndex = 2;
            label7.Text = "T.C.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 89);
            label6.Name = "label6";
            label6.Size = new Size(62, 24);
            label6.TabIndex = 1;
            label6.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 46);
            label5.Name = "label5";
            label5.Size = new Size(35, 24);
            label5.TabIndex = 0;
            label5.Text = "Ad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(64, 615);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(783, 100);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 235);
            panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(211, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(477, 184);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(694, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(299, 12);
            label11.Name = "label11";
            label11.Size = new Size(275, 33);
            label11.TabIndex = 0;
            label11.Text = "Simurg Hava Yolları";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(926, 727);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bilet Satin Al";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private Label label10;
        private ListBox listBox1;
        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label12;
        private Button button2;
    }
}