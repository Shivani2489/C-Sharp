
namespace Control_Assignment_01
{
    partial class frm_Emp_General_Details
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
            this.lbl_Employee_General_Details = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Known_Languages = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_General_Details
            // 
            this.lbl_Employee_General_Details.AutoSize = true;
            this.lbl_Employee_General_Details.BackColor = System.Drawing.Color.IndianRed;
            this.lbl_Employee_General_Details.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_General_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Employee_General_Details.Location = new System.Drawing.Point(302, 19);
            this.lbl_Employee_General_Details.Name = "lbl_Employee_General_Details";
            this.lbl_Employee_General_Details.Size = new System.Drawing.Size(406, 35);
            this.lbl_Employee_General_Details.TabIndex = 1;
            this.lbl_Employee_General_Details.Text = "Employee General Details";
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.White;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.gb_Gender.Location = new System.Drawing.Point(208, 238);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(291, 53);
            this.gb_Gender.TabIndex = 9;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(170, 19);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(65, 19);
            this.rb_Female.TabIndex = 0;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(57, 19);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(53, 19);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "R&D",
            "QA",
            "QC",
            "Development",
            "Testing",
            "Administration"});
            this.cmb_Department.Location = new System.Drawing.Point(209, 165);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(290, 26);
            this.cmb_Department.TabIndex = 8;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(209, 99);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(290, 26);
            this.tb_Name.TabIndex = 7;
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.lbl_Employee_Name.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(27, 101);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(131, 21);
            this.lbl_Employee_Name.TabIndex = 4;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.lbl_Gender.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Gender.Location = new System.Drawing.Point(27, 261);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(65, 21);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.lbl_Employee_Department.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(27, 167);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(178, 21);
            this.lbl_Employee_Department.TabIndex = 6;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(244, 466);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(613, 26);
            this.tb_Output.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.label1.Location = new System.Drawing.Point(135, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Output";
            // 
            // lbl_Known_Languages
            // 
            this.lbl_Known_Languages.AutoSize = true;
            this.lbl_Known_Languages.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.lbl_Known_Languages.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Known_Languages.Location = new System.Drawing.Point(542, 99);
            this.lbl_Known_Languages.Name = "lbl_Known_Languages";
            this.lbl_Known_Languages.Size = new System.Drawing.Size(144, 21);
            this.lbl_Known_Languages.TabIndex = 12;
            this.lbl_Known_Languages.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Constantia", 12.5F);
            this.lbl_Hobbies.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_Hobbies.Location = new System.Drawing.Point(542, 255);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(70, 21);
            this.lbl_Hobbies.TabIndex = 12;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.BackColor = System.Drawing.Color.White;
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.gb_Known_Languages.Location = new System.Drawing.Point(713, 101);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(255, 99);
            this.gb_Known_Languages.TabIndex = 13;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(143, 66);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(66, 19);
            this.cb_French.TabIndex = 0;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Location = new System.Drawing.Point(26, 66);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(70, 19);
            this.cb_English.TabIndex = 0;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Location = new System.Drawing.Point(143, 34);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(59, 19);
            this.cb_Hindi.TabIndex = 0;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Location = new System.Drawing.Point(26, 34);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(72, 19);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Trecking",
            "Gaming",
            "Cooking",
            "Reading",
            "Dancing",
            "Singing"});
            this.clb_Hobbies.Location = new System.Drawing.Point(713, 238);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(255, 130);
            this.clb_Hobbies.TabIndex = 14;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Submit.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(604, 392);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(122, 42);
            this.btn_Submit.TabIndex = 15;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Reset.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(291, 392);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(122, 42);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // frm_Emp_General_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(995, 509);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Languages);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_General_Details);
            this.Name = "frm_Emp_General_Details";
            this.Text = "Employee General Details";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_General_Details;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Known_Languages;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Reset;
    }
}