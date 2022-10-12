namespace Cash_Register_for_Cafes_and_Gas_Stations
{
    partial class Form1 : Form
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
            this.GasStation_groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullPrice_groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullOIlPrice_textBox1 = new System.Windows.Forms.TextBox();
            this.Clear_button1 = new System.Windows.Forms.Button();
            this.calculate_button1 = new System.Windows.Forms.Button();
            this.Sum_textBox2 = new System.Windows.Forms.TextBox();
            this.Count_textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sum_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Count_radioButton1 = new System.Windows.Forms.RadioButton();
            this.Price_textBox1 = new System.Windows.Forms.TextBox();
            this.Price_label1 = new System.Windows.Forms.Label();
            this.Oil_label1 = new System.Windows.Forms.Label();
            this.Oil_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cafe_groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearEat_button2 = new System.Windows.Forms.Button();
            this.CalcEat_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountC_textBox1 = new System.Windows.Forms.TextBox();
            this.CountH_textBox2 = new System.Windows.Forms.TextBox();
            this.CountH_textBox3 = new System.Windows.Forms.TextBox();
            this.CountF_textBox4 = new System.Windows.Forms.TextBox();
            this.eatPrice_label1 = new System.Windows.Forms.Label();
            this.Cola_textBox4 = new System.Windows.Forms.TextBox();
            this.Hamburger_textBox3 = new System.Windows.Forms.TextBox();
            this.HotDog_textBox2 = new System.Windows.Forms.TextBox();
            this.FrenchFries_textBox1 = new System.Windows.Forms.TextBox();
            this.Cola_checkBox4 = new System.Windows.Forms.CheckBox();
            this.Hamburger_checkBox3 = new System.Windows.Forms.CheckBox();
            this.HotDog_checkBox2 = new System.Windows.Forms.CheckBox();
            this.FrenchFries_checkBox1 = new System.Windows.Forms.CheckBox();
            this.FullSumm_groupBox3 = new System.Windows.Forms.GroupBox();
            this.FullPrice_textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FullEatSum_textBox1 = new System.Windows.Forms.TextBox();
            this.GasStation_groupBox1.SuspendLayout();
            this.FullPrice_groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Cafe_groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FullSumm_groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasStation_groupBox1
            // 
            this.GasStation_groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GasStation_groupBox1.Controls.Add(this.FullPrice_groupBox1);
            this.GasStation_groupBox1.Controls.Add(this.Clear_button1);
            this.GasStation_groupBox1.Controls.Add(this.calculate_button1);
            this.GasStation_groupBox1.Controls.Add(this.Sum_textBox2);
            this.GasStation_groupBox1.Controls.Add(this.Count_textBox1);
            this.GasStation_groupBox1.Controls.Add(this.panel1);
            this.GasStation_groupBox1.Controls.Add(this.Price_textBox1);
            this.GasStation_groupBox1.Controls.Add(this.Price_label1);
            this.GasStation_groupBox1.Controls.Add(this.Oil_label1);
            this.GasStation_groupBox1.Controls.Add(this.Oil_comboBox1);
            this.GasStation_groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GasStation_groupBox1.Location = new System.Drawing.Point(27, 14);
            this.GasStation_groupBox1.Name = "GasStation_groupBox1";
            this.GasStation_groupBox1.Size = new System.Drawing.Size(265, 330);
            this.GasStation_groupBox1.TabIndex = 1;
            this.GasStation_groupBox1.TabStop = false;
            this.GasStation_groupBox1.Text = " Автозаправка";
            // 
            // FullPrice_groupBox1
            // 
            this.FullPrice_groupBox1.Controls.Add(this.FullOIlPrice_textBox1);
            this.FullPrice_groupBox1.Location = new System.Drawing.Point(6, 253);
            this.FullPrice_groupBox1.Name = "FullPrice_groupBox1";
            this.FullPrice_groupBox1.Size = new System.Drawing.Size(253, 71);
            this.FullPrice_groupBox1.TabIndex = 12;
            this.FullPrice_groupBox1.TabStop = false;
            this.FullPrice_groupBox1.Text = "Сумма оплаты топлива";
            // 
            // FullOIlPrice_textBox1
            // 
            this.FullOIlPrice_textBox1.Location = new System.Drawing.Point(79, 28);
            this.FullOIlPrice_textBox1.Multiline = true;
            this.FullOIlPrice_textBox1.Name = "FullOIlPrice_textBox1";
            this.FullOIlPrice_textBox1.ReadOnly = true;
            this.FullOIlPrice_textBox1.Size = new System.Drawing.Size(96, 35);
            this.FullOIlPrice_textBox1.TabIndex = 0;
            this.FullOIlPrice_textBox1.Text = "0";
            this.FullOIlPrice_textBox1.TextChanged += new System.EventHandler(this.FullPrice_textBox1_TextChanged);
            // 
            // Clear_button1
            // 
            this.Clear_button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear_button1.Location = new System.Drawing.Point(72, 224);
            this.Clear_button1.Name = "Clear_button1";
            this.Clear_button1.Size = new System.Drawing.Size(56, 23);
            this.Clear_button1.TabIndex = 11;
            this.Clear_button1.Text = "Очистить";
            this.Clear_button1.UseVisualStyleBackColor = true;
            this.Clear_button1.Click += new System.EventHandler(this.Clear_button1_Click);
            // 
            // calculate_button1
            // 
            this.calculate_button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculate_button1.Location = new System.Drawing.Point(6, 224);
            this.calculate_button1.Name = "calculate_button1";
            this.calculate_button1.Size = new System.Drawing.Size(60, 23);
            this.calculate_button1.TabIndex = 10;
            this.calculate_button1.Text = "Подсчёт";
            this.calculate_button1.UseVisualStyleBackColor = true;
            this.calculate_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sum_textBox2
            // 
            this.Sum_textBox2.Location = new System.Drawing.Point(133, 193);
            this.Sum_textBox2.Name = "Sum_textBox2";
            this.Sum_textBox2.ReadOnly = true;
            this.Sum_textBox2.Size = new System.Drawing.Size(86, 29);
            this.Sum_textBox2.TabIndex = 9;
            this.Sum_textBox2.Text = "0";
            this.Sum_textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Count_textBox1
            // 
            this.Count_textBox1.Location = new System.Drawing.Point(133, 144);
            this.Count_textBox1.Name = "Count_textBox1";
            this.Count_textBox1.ReadOnly = true;
            this.Count_textBox1.Size = new System.Drawing.Size(86, 29);
            this.Count_textBox1.TabIndex = 8;
            this.Count_textBox1.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sum_radioButton2);
            this.panel1.Controls.Add(this.Count_radioButton1);
            this.panel1.Location = new System.Drawing.Point(6, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 81);
            this.panel1.TabIndex = 7;
            // 
            // Sum_radioButton2
            // 
            this.Sum_radioButton2.AutoSize = true;
            this.Sum_radioButton2.Location = new System.Drawing.Point(19, 52);
            this.Sum_radioButton2.Name = "Sum_radioButton2";
            this.Sum_radioButton2.Size = new System.Drawing.Size(62, 25);
            this.Sum_radioButton2.TabIndex = 5;
            this.Sum_radioButton2.TabStop = true;
            this.Sum_radioButton2.Text = "Sum";
            this.Sum_radioButton2.UseVisualStyleBackColor = true;
            this.Sum_radioButton2.CheckedChanged += new System.EventHandler(this.Sum_radioButton2_CheckedChanged_1);
            // 
            // Count_radioButton1
            // 
            this.Count_radioButton1.AutoSize = true;
            this.Count_radioButton1.Location = new System.Drawing.Point(19, 7);
            this.Count_radioButton1.Name = "Count_radioButton1";
            this.Count_radioButton1.Size = new System.Drawing.Size(74, 25);
            this.Count_radioButton1.TabIndex = 4;
            this.Count_radioButton1.TabStop = true;
            this.Count_radioButton1.Text = "Count";
            this.Count_radioButton1.UseVisualStyleBackColor = true;
            this.Count_radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Price_textBox1
            // 
            this.Price_textBox1.Location = new System.Drawing.Point(133, 88);
            this.Price_textBox1.Name = "Price_textBox1";
            this.Price_textBox1.ReadOnly = true;
            this.Price_textBox1.Size = new System.Drawing.Size(86, 29);
            this.Price_textBox1.TabIndex = 6;
            this.Price_textBox1.Text = "0";
            this.Price_textBox1.TextChanged += new System.EventHandler(this.Price_textBox1_TextChanged);
            // 
            // Price_label1
            // 
            this.Price_label1.AutoSize = true;
            this.Price_label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price_label1.Location = new System.Drawing.Point(6, 92);
            this.Price_label1.Name = "Price_label1";
            this.Price_label1.Size = new System.Drawing.Size(46, 20);
            this.Price_label1.TabIndex = 5;
            this.Price_label1.Text = "Цена";
            // 
            // Oil_label1
            // 
            this.Oil_label1.AutoSize = true;
            this.Oil_label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Oil_label1.Location = new System.Drawing.Point(6, 43);
            this.Oil_label1.Name = "Oil_label1";
            this.Oil_label1.Size = new System.Drawing.Size(60, 20);
            this.Oil_label1.TabIndex = 4;
            this.Oil_label1.Text = "Бензин";
            this.Oil_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Oil_comboBox1
            // 
            this.Oil_comboBox1.AllowDrop = true;
            this.Oil_comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Oil_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Oil_comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Oil_comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Oil_comboBox1.FormattingEnabled = true;
            this.Oil_comboBox1.Items.AddRange(new object[] {
            "AI-92",
            "AI-95",
            "Diesel"});
            this.Oil_comboBox1.Location = new System.Drawing.Point(133, 40);
            this.Oil_comboBox1.Name = "Oil_comboBox1";
            this.Oil_comboBox1.Size = new System.Drawing.Size(86, 23);
            this.Oil_comboBox1.TabIndex = 2;
            this.Oil_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Oil_comboBox1_SelectedIndexChanged);
            // 
            // Cafe_groupBox2
            // 
            this.Cafe_groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cafe_groupBox2.Controls.Add(this.groupBox1);
            this.Cafe_groupBox2.Controls.Add(this.ClearEat_button2);
            this.Cafe_groupBox2.Controls.Add(this.CalcEat_button1);
            this.Cafe_groupBox2.Controls.Add(this.label1);
            this.Cafe_groupBox2.Controls.Add(this.CountC_textBox1);
            this.Cafe_groupBox2.Controls.Add(this.CountH_textBox2);
            this.Cafe_groupBox2.Controls.Add(this.CountH_textBox3);
            this.Cafe_groupBox2.Controls.Add(this.CountF_textBox4);
            this.Cafe_groupBox2.Controls.Add(this.eatPrice_label1);
            this.Cafe_groupBox2.Controls.Add(this.Cola_textBox4);
            this.Cafe_groupBox2.Controls.Add(this.Hamburger_textBox3);
            this.Cafe_groupBox2.Controls.Add(this.HotDog_textBox2);
            this.Cafe_groupBox2.Controls.Add(this.FrenchFries_textBox1);
            this.Cafe_groupBox2.Controls.Add(this.Cola_checkBox4);
            this.Cafe_groupBox2.Controls.Add(this.Hamburger_checkBox3);
            this.Cafe_groupBox2.Controls.Add(this.HotDog_checkBox2);
            this.Cafe_groupBox2.Controls.Add(this.FrenchFries_checkBox1);
            this.Cafe_groupBox2.Location = new System.Drawing.Point(361, 14);
            this.Cafe_groupBox2.Name = "Cafe_groupBox2";
            this.Cafe_groupBox2.Size = new System.Drawing.Size(265, 330);
            this.Cafe_groupBox2.TabIndex = 2;
            this.Cafe_groupBox2.TabStop = false;
            this.Cafe_groupBox2.Text = "Кафе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullEatSum_textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сумма оплаты топлива";
            // 
            // ClearEat_button2
            // 
            this.ClearEat_button2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearEat_button2.Location = new System.Drawing.Point(72, 224);
            this.ClearEat_button2.Name = "ClearEat_button2";
            this.ClearEat_button2.Size = new System.Drawing.Size(56, 23);
            this.ClearEat_button2.TabIndex = 15;
            this.ClearEat_button2.Text = "Очистить";
            this.ClearEat_button2.UseVisualStyleBackColor = true;
            this.ClearEat_button2.Click += new System.EventHandler(this.ClearEat_button2_Click);
            // 
            // CalcEat_button1
            // 
            this.CalcEat_button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcEat_button1.Location = new System.Drawing.Point(6, 224);
            this.CalcEat_button1.Name = "CalcEat_button1";
            this.CalcEat_button1.Size = new System.Drawing.Size(60, 23);
            this.CalcEat_button1.TabIndex = 14;
            this.CalcEat_button1.Text = "Подсчёт";
            this.CalcEat_button1.UseVisualStyleBackColor = true;
            this.CalcEat_button1.Click += new System.EventHandler(this.CalcEat_button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Count";
            // 
            // CountC_textBox1
            // 
            this.CountC_textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountC_textBox1.Location = new System.Drawing.Point(199, 173);
            this.CountC_textBox1.Name = "CountC_textBox1";
            this.CountC_textBox1.ReadOnly = true;
            this.CountC_textBox1.Size = new System.Drawing.Size(57, 29);
            this.CountC_textBox1.TabIndex = 12;
            this.CountC_textBox1.Text = "0";
            this.CountC_textBox1.TextChanged += new System.EventHandler(this.CountC_textBox1_TextChanged);
            // 
            // CountH_textBox2
            // 
            this.CountH_textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountH_textBox2.Location = new System.Drawing.Point(199, 130);
            this.CountH_textBox2.Name = "CountH_textBox2";
            this.CountH_textBox2.ReadOnly = true;
            this.CountH_textBox2.Size = new System.Drawing.Size(57, 29);
            this.CountH_textBox2.TabIndex = 11;
            this.CountH_textBox2.Text = "0";
            // 
            // CountH_textBox3
            // 
            this.CountH_textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountH_textBox3.Location = new System.Drawing.Point(199, 87);
            this.CountH_textBox3.Name = "CountH_textBox3";
            this.CountH_textBox3.ReadOnly = true;
            this.CountH_textBox3.Size = new System.Drawing.Size(57, 29);
            this.CountH_textBox3.TabIndex = 10;
            this.CountH_textBox3.Text = "0";
            // 
            // CountF_textBox4
            // 
            this.CountF_textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountF_textBox4.Location = new System.Drawing.Point(199, 44);
            this.CountF_textBox4.Name = "CountF_textBox4";
            this.CountF_textBox4.ReadOnly = true;
            this.CountF_textBox4.Size = new System.Drawing.Size(57, 29);
            this.CountF_textBox4.TabIndex = 9;
            this.CountF_textBox4.Text = "0";
            this.CountF_textBox4.TextChanged += new System.EventHandler(this.CountF_textBox4_TextChanged);
            // 
            // eatPrice_label1
            // 
            this.eatPrice_label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eatPrice_label1.Location = new System.Drawing.Point(116, 19);
            this.eatPrice_label1.Name = "eatPrice_label1";
            this.eatPrice_label1.Size = new System.Drawing.Size(57, 23);
            this.eatPrice_label1.TabIndex = 8;
            this.eatPrice_label1.Text = "Price";
            // 
            // Cola_textBox4
            // 
            this.Cola_textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cola_textBox4.Location = new System.Drawing.Point(116, 173);
            this.Cola_textBox4.Name = "Cola_textBox4";
            this.Cola_textBox4.ReadOnly = true;
            this.Cola_textBox4.Size = new System.Drawing.Size(57, 29);
            this.Cola_textBox4.TabIndex = 7;
            this.Cola_textBox4.Text = "1";
            // 
            // Hamburger_textBox3
            // 
            this.Hamburger_textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hamburger_textBox3.Location = new System.Drawing.Point(116, 130);
            this.Hamburger_textBox3.Name = "Hamburger_textBox3";
            this.Hamburger_textBox3.ReadOnly = true;
            this.Hamburger_textBox3.Size = new System.Drawing.Size(57, 29);
            this.Hamburger_textBox3.TabIndex = 6;
            this.Hamburger_textBox3.Text = "4";
            // 
            // HotDog_textBox2
            // 
            this.HotDog_textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HotDog_textBox2.Location = new System.Drawing.Point(116, 87);
            this.HotDog_textBox2.Name = "HotDog_textBox2";
            this.HotDog_textBox2.ReadOnly = true;
            this.HotDog_textBox2.Size = new System.Drawing.Size(57, 29);
            this.HotDog_textBox2.TabIndex = 5;
            this.HotDog_textBox2.Text = "3";
            // 
            // FrenchFries_textBox1
            // 
            this.FrenchFries_textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrenchFries_textBox1.Location = new System.Drawing.Point(116, 44);
            this.FrenchFries_textBox1.Name = "FrenchFries_textBox1";
            this.FrenchFries_textBox1.ReadOnly = true;
            this.FrenchFries_textBox1.Size = new System.Drawing.Size(57, 29);
            this.FrenchFries_textBox1.TabIndex = 4;
            this.FrenchFries_textBox1.Text = "2";
            // 
            // Cola_checkBox4
            // 
            this.Cola_checkBox4.Location = new System.Drawing.Point(6, 171);
            this.Cola_checkBox4.Name = "Cola_checkBox4";
            this.Cola_checkBox4.Size = new System.Drawing.Size(120, 37);
            this.Cola_checkBox4.TabIndex = 3;
            this.Cola_checkBox4.Text = "Cola";
            this.Cola_checkBox4.UseVisualStyleBackColor = true;
            this.Cola_checkBox4.CheckedChanged += new System.EventHandler(this.Cola_checkBox4_CheckedChanged);
            // 
            // Hamburger_checkBox3
            // 
            this.Hamburger_checkBox3.Location = new System.Drawing.Point(6, 128);
            this.Hamburger_checkBox3.Name = "Hamburger_checkBox3";
            this.Hamburger_checkBox3.Size = new System.Drawing.Size(120, 37);
            this.Hamburger_checkBox3.TabIndex = 2;
            this.Hamburger_checkBox3.Text = "Hamburger";
            this.Hamburger_checkBox3.UseVisualStyleBackColor = true;
            this.Hamburger_checkBox3.CheckedChanged += new System.EventHandler(this.Hamburger_checkBox3_CheckedChanged);
            // 
            // HotDog_checkBox2
            // 
            this.HotDog_checkBox2.Location = new System.Drawing.Point(6, 85);
            this.HotDog_checkBox2.Name = "HotDog_checkBox2";
            this.HotDog_checkBox2.Size = new System.Drawing.Size(120, 37);
            this.HotDog_checkBox2.TabIndex = 1;
            this.HotDog_checkBox2.Text = "Hot Dog";
            this.HotDog_checkBox2.UseVisualStyleBackColor = true;
            this.HotDog_checkBox2.CheckedChanged += new System.EventHandler(this.HotDog_checkBox2_CheckedChanged);
            // 
            // FrenchFries_checkBox1
            // 
            this.FrenchFries_checkBox1.Location = new System.Drawing.Point(6, 42);
            this.FrenchFries_checkBox1.Name = "FrenchFries_checkBox1";
            this.FrenchFries_checkBox1.Size = new System.Drawing.Size(120, 37);
            this.FrenchFries_checkBox1.TabIndex = 0;
            this.FrenchFries_checkBox1.Text = "French Fries";
            this.FrenchFries_checkBox1.UseVisualStyleBackColor = true;
            this.FrenchFries_checkBox1.CheckedChanged += new System.EventHandler(this.FrenchFries_checkBox1_CheckedChanged);
            // 
            // FullSumm_groupBox3
            // 
            this.FullSumm_groupBox3.Controls.Add(this.button1);
            this.FullSumm_groupBox3.Controls.Add(this.FullPrice_textBox1);
            this.FullSumm_groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FullSumm_groupBox3.Location = new System.Drawing.Point(27, 361);
            this.FullSumm_groupBox3.Name = "FullSumm_groupBox3";
            this.FullSumm_groupBox3.Size = new System.Drawing.Size(590, 153);
            this.FullSumm_groupBox3.TabIndex = 3;
            this.FullSumm_groupBox3.TabStop = false;
            this.FullSumm_groupBox3.Text = "Вся стоимость оплаты";
            // 
            // FullPrice_textBox1
            // 
            this.FullPrice_textBox1.Location = new System.Drawing.Point(334, 50);
            this.FullPrice_textBox1.Multiline = true;
            this.FullPrice_textBox1.Name = "FullPrice_textBox1";
            this.FullPrice_textBox1.ReadOnly = true;
            this.FullPrice_textBox1.Size = new System.Drawing.Size(201, 79);
            this.FullPrice_textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(34, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 79);
            this.button1.TabIndex = 15;
            this.button1.Text = "Подсчёт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FullEatSum_textBox1
            // 
            this.FullEatSum_textBox1.Location = new System.Drawing.Point(79, 28);
            this.FullEatSum_textBox1.Multiline = true;
            this.FullEatSum_textBox1.Name = "FullEatSum_textBox1";
            this.FullEatSum_textBox1.ReadOnly = true;
            this.FullEatSum_textBox1.Size = new System.Drawing.Size(96, 35);
            this.FullEatSum_textBox1.TabIndex = 0;
            this.FullEatSum_textBox1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(638, 526);
            this.Controls.Add(this.FullSumm_groupBox3);
            this.Controls.Add(this.Cafe_groupBox2);
            this.Controls.Add(this.GasStation_groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GasStation_groupBox1.ResumeLayout(false);
            this.GasStation_groupBox1.PerformLayout();
            this.FullPrice_groupBox1.ResumeLayout(false);
            this.FullPrice_groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Cafe_groupBox2.ResumeLayout(false);
            this.Cafe_groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FullSumm_groupBox3.ResumeLayout(false);
            this.FullSumm_groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GasStation_groupBox1;
        private GroupBox Cafe_groupBox2;
        private GroupBox FullSumm_groupBox3;
        private ComboBox Oil_comboBox1;
        private Label Oil_label1;
        private TextBox Price_textBox1;
        private Label Price_label1;
        private Panel panel1;
        private TextBox Sum_textBox2;
        private TextBox Count_textBox1;
        private RadioButton Sum_radioButton2;
        private RadioButton Count_radioButton1;
        private Button calculate_button1;
        private Button Clear_button1;
        private GroupBox FullPrice_groupBox1;
        private TextBox FullOIlPrice_textBox1;
        private CheckBox Cola_checkBox4;
        private CheckBox Hamburger_checkBox3;
        private CheckBox HotDog_checkBox2;
        private CheckBox FrenchFries_checkBox1;
        private TextBox FrenchFries_textBox1;
        private Label eatPrice_label1;
        private TextBox Cola_textBox4;
        private TextBox Hamburger_textBox3;
        private TextBox HotDog_textBox2;
        private Label label1;
        private TextBox CountC_textBox1;
        private TextBox CountH_textBox2;
        private TextBox CountH_textBox3;
        private TextBox CountF_textBox4;
        private Button ClearEat_button2;
        private Button CalcEat_button1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox FullPrice_textBox1;
        private TextBox FullEatSum_textBox1;
    }
}