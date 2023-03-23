namespace DairyFarmTask
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VetName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.HealthList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cowid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Diagnosis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.Event = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Treatment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CowName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthList)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.DarkGray;
            this.Date.BorderRadius = 0;
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date.FormatCustom = null;
            this.Date.Location = new System.Drawing.Point(391, 246);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(191, 36);
            this.Date.TabIndex = 116;
            this.Date.Value = new System.DateTime(2023, 3, 9, 5, 32, 14, 536);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 68);
            this.label18.TabIndex = 22;
            this.label18.Text = "Dairy Farm Software";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(394, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 38);
            this.label9.TabIndex = 115;
            this.label9.Text = "Date";
            // 
            // VetName
            // 
            this.VetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VetName.HintForeColor = System.Drawing.Color.Empty;
            this.VetName.HintText = "";
            this.VetName.isPassword = false;
            this.VetName.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.VetName.LineIdleColor = System.Drawing.Color.Gray;
            this.VetName.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.VetName.LineThickness = 4;
            this.VetName.Location = new System.Drawing.Point(1243, 241);
            this.VetName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.VetName.Name = "VetName";
            this.VetName.Size = new System.Drawing.Size(191, 41);
            this.VetName.TabIndex = 95;
            this.VetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 929);
            this.panel1.TabIndex = 93;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DairyFarmTask.Properties.Resources.icons8_cow_breed_161;
            this.pictureBox8.Location = new System.Drawing.Point(80, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(151, 120);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // HealthList
            // 
            this.HealthList.AllowUserToAddRows = false;
            this.HealthList.AllowUserToDeleteRows = false;
            this.HealthList.AllowUserToResizeColumns = false;
            this.HealthList.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.HealthList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HealthList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.HealthList.ColumnHeadersHeight = 24;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HealthList.DefaultCellStyle = dataGridViewCellStyle12;
            this.HealthList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HealthList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.HealthList.Location = new System.Drawing.Point(331, 431);
            this.HealthList.MultiSelect = false;
            this.HealthList.Name = "HealthList";
            this.HealthList.RowHeadersVisible = false;
            this.HealthList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.HealthList.ShowEditingIcon = false;
            this.HealthList.Size = new System.Drawing.Size(1195, 544);
            this.HealthList.TabIndex = 114;
            this.HealthList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.HealthList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.HealthList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HealthList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HealthList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HealthList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HealthList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HealthList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.HealthList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.HealthList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HealthList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.HealthList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HealthList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.HealthList.ThemeStyle.HeaderStyle.Height = 24;
            this.HealthList.ThemeStyle.ReadOnly = false;
            this.HealthList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HealthList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HealthList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.HealthList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.HealthList.ThemeStyle.RowsStyle.Height = 22;
            this.HealthList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.HealthList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Cowid
            // 
            this.Cowid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cowid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Cowid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cowid.FormattingEnabled = true;
            this.Cowid.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Cowid.Location = new System.Drawing.Point(391, 120);
            this.Cowid.Name = "Cowid";
            this.Cowid.Size = new System.Drawing.Size(192, 29);
            this.Cowid.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dairy Farm Software";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2GradientPanel1.Controls.Add(this.label19);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1538, 54);
            this.guna2GradientPanel1.TabIndex = 94;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(1279, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 32);
            this.label19.TabIndex = 28;
            this.label19.Text = "Employees";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1115, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 44);
            this.button4.TabIndex = 112;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(942, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 44);
            this.button3.TabIndex = 111;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(773, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 110;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(607, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 109;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(855, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 37);
            this.label13.TabIndex = 108;
            this.label13.Text = "Employees List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(934, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 38);
            this.label10.TabIndex = 107;
            this.label10.Text = "Cost of Treatment";
            // 
            // Cost
            // 
            this.Cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cost.HintForeColor = System.Drawing.Color.Empty;
            this.Cost.HintText = "";
            this.Cost.isPassword = false;
            this.Cost.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.Cost.LineIdleColor = System.Drawing.Color.Gray;
            this.Cost.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.Cost.LineThickness = 4;
            this.Cost.Location = new System.Drawing.Point(941, 241);
            this.Cost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(191, 41);
            this.Cost.TabIndex = 106;
            this.Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(667, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 38);
            this.label11.TabIndex = 105;
            this.label11.Text = "Treatment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(1236, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 38);
            this.label12.TabIndex = 103;
            this.label12.Text = "Vet Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(1236, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 38);
            this.label4.TabIndex = 102;
            this.label4.Text = "Diagnosis";
            // 
            // Diagnosis
            // 
            this.Diagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Diagnosis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Diagnosis.HintForeColor = System.Drawing.Color.Empty;
            this.Diagnosis.HintText = "";
            this.Diagnosis.isPassword = false;
            this.Diagnosis.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.Diagnosis.LineIdleColor = System.Drawing.Color.Gray;
            this.Diagnosis.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.Diagnosis.LineThickness = 4;
            this.Diagnosis.Location = new System.Drawing.Point(1243, 116);
            this.Diagnosis.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(191, 41);
            this.Diagnosis.TabIndex = 101;
            this.Diagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(934, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 38);
            this.label8.TabIndex = 100;
            this.label8.Text = "Event";
            // 
            // Event
            // 
            this.Event.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Event.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Event.HintForeColor = System.Drawing.Color.Empty;
            this.Event.HintText = "";
            this.Event.isPassword = false;
            this.Event.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.Event.LineIdleColor = System.Drawing.Color.Gray;
            this.Event.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.Event.LineThickness = 4;
            this.Event.Location = new System.Drawing.Point(941, 116);
            this.Event.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(191, 41);
            this.Event.TabIndex = 99;
            this.Event.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(662, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 38);
            this.label3.TabIndex = 98;
            this.label3.Text = "Cow Name";
            // 
            // Treatment
            // 
            this.Treatment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Treatment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Treatment.HintForeColor = System.Drawing.Color.Empty;
            this.Treatment.HintText = "";
            this.Treatment.isPassword = false;
            this.Treatment.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.Treatment.LineIdleColor = System.Drawing.Color.Gray;
            this.Treatment.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.Treatment.LineThickness = 4;
            this.Treatment.Location = new System.Drawing.Point(669, 241);
            this.Treatment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(191, 41);
            this.Treatment.TabIndex = 104;
            this.Treatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CowName
            // 
            this.CowName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CowName.Enabled = false;
            this.CowName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CowName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CowName.HintForeColor = System.Drawing.Color.Empty;
            this.CowName.HintText = "";
            this.CowName.isPassword = false;
            this.CowName.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.CowName.LineIdleColor = System.Drawing.Color.Gray;
            this.CowName.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.CowName.LineThickness = 4;
            this.CowName.Location = new System.Drawing.Point(669, 116);
            this.CowName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CowName.Name = "CowName";
            this.CowName.Size = new System.Drawing.Size(191, 41);
            this.CowName.TabIndex = 97;
            this.CowName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(394, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 38);
            this.label2.TabIndex = 96;
            this.label2.Text = "Gender";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 983);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VetName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HealthList);
            this.Controls.Add(this.Cowid);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Treatment);
            this.Controls.Add(this.CowName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthList)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker Date;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox VetName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Guna.UI2.WinForms.Guna2DataGridView HealthList;
        private System.Windows.Forms.ComboBox Cowid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Diagnosis;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Event;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Treatment;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CowName;
        private System.Windows.Forms.Label label2;
    }
}