
namespace Controls_Assignment
{
    partial class Use_CheckBox_CheckListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Use_CheckBox_CheckListBox));
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Dept = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.lbl_Result_Text = new System.Windows.Forms.Label();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.lbl_Lang = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.clb_Hobiies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Name_Err = new System.Windows.Forms.Label();
            this.lbl_Dept_Err = new System.Windows.Forms.Label();
            this.lbl_Gender_Err = new System.Windows.Forms.Label();
            this.lbl_Lang_Err = new System.Windows.Forms.Label();
            this.lbl_Hobby_Err = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.pnl_Output.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.Info;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Location = new System.Drawing.Point(269, 305);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(296, 54);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(30, 19);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 20);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(183, 19);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 20);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Reset.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Reset.Location = new System.Drawing.Point(318, 434);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(117, 42);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Submit.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Submit.Location = new System.Drawing.Point(703, 434);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(117, 42);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dept.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Items.AddRange(new object[] {
            "R&D",
            "HRD",
            "Testing",
            "Management"});
            this.cmb_Dept.Location = new System.Drawing.Point(269, 209);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(296, 24);
            this.cmb_Dept.TabIndex = 2;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(269, 121);
            this.tb_Name.MaxLength = 60;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(296, 26);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Output.Location = new System.Drawing.Point(58, 525);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(76, 25);
            this.lbl_Output.TabIndex = 12;
            this.lbl_Output.Text = "Output";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Gender.Location = new System.Drawing.Point(22, 321);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(78, 25);
            this.lbl_Gender.TabIndex = 13;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Dept
            // 
            this.lbl_Dept.AutoSize = true;
            this.lbl_Dept.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Dept.Location = new System.Drawing.Point(22, 209);
            this.lbl_Dept.Name = "lbl_Dept";
            this.lbl_Dept.Size = new System.Drawing.Size(214, 25);
            this.lbl_Dept.TabIndex = 14;
            this.lbl_Dept.Text = "Employee Department";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Name.Location = new System.Drawing.Point(22, 121);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(157, 25);
            this.lbl_Name.TabIndex = 15;
            this.lbl_Name.Text = "Employee Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Uighur", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(349, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(422, 70);
            this.lbl_Header.TabIndex = 16;
            this.lbl_Header.Text = "Employee General Details";
            // 
            // pnl_Output
            // 
            this.pnl_Output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Output.Controls.Add(this.lbl_Result_Text);
            this.pnl_Output.Location = new System.Drawing.Point(162, 519);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(952, 36);
            this.pnl_Output.TabIndex = 22;
            // 
            // lbl_Result_Text
            // 
            this.lbl_Result_Text.AutoSize = true;
            this.lbl_Result_Text.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result_Text.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Result_Text.Location = new System.Drawing.Point(21, 10);
            this.lbl_Result_Text.Name = "lbl_Result_Text";
            this.lbl_Result_Text.Size = new System.Drawing.Size(252, 17);
            this.lbl_Result_Text.TabIndex = 0;
            this.lbl_Result_Text.Text = "Output Of Submit Button Appears Here";
            this.lbl_Result_Text.Visible = false;
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.BackColor = System.Drawing.SystemColors.Info;
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Location = new System.Drawing.Point(818, 103);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(296, 101);
            this.gb_Known_Languages.TabIndex = 6;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cb_French.Location = new System.Drawing.Point(183, 62);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(71, 20);
            this.cb_French.TabIndex = 10;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cb_English.Location = new System.Drawing.Point(28, 62);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(75, 20);
            this.cb_English.TabIndex = 9;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cb_Hindi.Location = new System.Drawing.Point(183, 27);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(63, 20);
            this.cb_Hindi.TabIndex = 8;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cb_Marathi.Location = new System.Drawing.Point(28, 27);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(76, 20);
            this.cb_Marathi.TabIndex = 7;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // lbl_Lang
            // 
            this.lbl_Lang.AutoSize = true;
            this.lbl_Lang.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Lang.Location = new System.Drawing.Point(637, 121);
            this.lbl_Lang.Name = "lbl_Lang";
            this.lbl_Lang.Size = new System.Drawing.Size(175, 25);
            this.lbl_Lang.TabIndex = 24;
            this.lbl_Lang.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_Hobbies.Location = new System.Drawing.Point(646, 280);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(86, 25);
            this.lbl_Hobbies.TabIndex = 24;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // clb_Hobiies
            // 
            this.clb_Hobiies.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.clb_Hobiies.FormattingEnabled = true;
            this.clb_Hobiies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Tracking",
            "Gaming",
            "Cooking",
            "Reading"});
            this.clb_Hobiies.Location = new System.Drawing.Point(818, 280);
            this.clb_Hobiies.Name = "clb_Hobiies";
            this.clb_Hobiies.Size = new System.Drawing.Size(212, 130);
            this.clb_Hobiies.TabIndex = 11;
            // 
            // lbl_Name_Err
            // 
            this.lbl_Name_Err.AutoSize = true;
            this.lbl_Name_Err.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Err.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Name_Err.Location = new System.Drawing.Point(477, 150);
            this.lbl_Name_Err.Name = "lbl_Name_Err";
            this.lbl_Name_Err.Size = new System.Drawing.Size(69, 14);
            this.lbl_Name_Err.TabIndex = 25;
            this.lbl_Name_Err.Text = "Name Error";
            this.lbl_Name_Err.Visible = false;
            // 
            // lbl_Dept_Err
            // 
            this.lbl_Dept_Err.AutoSize = true;
            this.lbl_Dept_Err.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.lbl_Dept_Err.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Dept_Err.Location = new System.Drawing.Point(482, 236);
            this.lbl_Dept_Err.Name = "lbl_Dept_Err";
            this.lbl_Dept_Err.Size = new System.Drawing.Size(64, 14);
            this.lbl_Dept_Err.TabIndex = 25;
            this.lbl_Dept_Err.Text = "Dept Error";
            this.lbl_Dept_Err.Visible = false;
            // 
            // lbl_Gender_Err
            // 
            this.lbl_Gender_Err.AutoSize = true;
            this.lbl_Gender_Err.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.lbl_Gender_Err.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Gender_Err.Location = new System.Drawing.Point(469, 362);
            this.lbl_Gender_Err.Name = "lbl_Gender_Err";
            this.lbl_Gender_Err.Size = new System.Drawing.Size(77, 14);
            this.lbl_Gender_Err.TabIndex = 25;
            this.lbl_Gender_Err.Text = "Gender Error";
            this.lbl_Gender_Err.Visible = false;
            // 
            // lbl_Lang_Err
            // 
            this.lbl_Lang_Err.AutoSize = true;
            this.lbl_Lang_Err.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.lbl_Lang_Err.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Lang_Err.Location = new System.Drawing.Point(1036, 209);
            this.lbl_Lang_Err.Name = "lbl_Lang_Err";
            this.lbl_Lang_Err.Size = new System.Drawing.Size(64, 14);
            this.lbl_Lang_Err.TabIndex = 25;
            this.lbl_Lang_Err.Text = "Lang Error";
            this.lbl_Lang_Err.Visible = false;
            // 
            // lbl_Hobby_Err
            // 
            this.lbl_Hobby_Err.AutoSize = true;
            this.lbl_Hobby_Err.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.lbl_Hobby_Err.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Hobby_Err.Location = new System.Drawing.Point(989, 413);
            this.lbl_Hobby_Err.Name = "lbl_Hobby_Err";
            this.lbl_Hobby_Err.Size = new System.Drawing.Size(75, 14);
            this.lbl_Hobby_Err.TabIndex = 25;
            this.lbl_Hobby_Err.Text = "Hobby Error";
            this.lbl_Hobby_Err.Visible = false;
            // 
            // Use_CheckBox_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1144, 578);
            this.Controls.Add(this.lbl_Hobby_Err);
            this.Controls.Add(this.lbl_Lang_Err);
            this.Controls.Add(this.lbl_Gender_Err);
            this.Controls.Add(this.lbl_Dept_Err);
            this.Controls.Add(this.lbl_Name_Err);
            this.Controls.Add(this.clb_Hobiies);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Lang);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_Dept);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Dept);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Use_CheckBox_CheckListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use Check Box CheckListBox";
            this.Load += new System.EventHandler(this.Use_CheckBox_CheckListBox_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Dept;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.Label lbl_Result_Text;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Label lbl_Lang;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.CheckedListBox clb_Hobiies;
        private System.Windows.Forms.Label lbl_Name_Err;
        private System.Windows.Forms.Label lbl_Dept_Err;
        private System.Windows.Forms.Label lbl_Gender_Err;
        private System.Windows.Forms.Label lbl_Lang_Err;
        private System.Windows.Forms.Label lbl_Hobby_Err;
    }
}