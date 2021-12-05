namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.TeacherName = new System.Windows.Forms.TextBox();
            this.TeacherSurname = new System.Windows.Forms.TextBox();
            this.TeacherAge = new System.Windows.Forms.TextBox();
            this.TeacherSex = new System.Windows.Forms.TextBox();
            this.TeacherDiscipline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TeacherCourse_Number = new System.Windows.Forms.TextBox();
            this.TeacherAddressHouse_Number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TeacherAddressCity = new System.Windows.Forms.TextBox();
            this.TeacherAddressCountry = new System.Windows.Forms.TextBox();
            this.TeacherAddressStreet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.AddTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeacherButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTeacherButton.Location = new System.Drawing.Point(31, 622);
            this.AddTeacherButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(279, 53);
            this.AddTeacherButton.TabIndex = 0;
            this.AddTeacherButton.Text = "Добавить преподавателя";
            this.AddTeacherButton.UseVisualStyleBackColor = false;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // TeacherName
            // 
            this.TeacherName.Location = new System.Drawing.Point(31, 37);
            this.TeacherName.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(282, 22);
            this.TeacherName.TabIndex = 1;
            // 
            // TeacherSurname
            // 
            this.TeacherSurname.Location = new System.Drawing.Point(31, 97);
            this.TeacherSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSurname.Name = "TeacherSurname";
            this.TeacherSurname.Size = new System.Drawing.Size(282, 22);
            this.TeacherSurname.TabIndex = 2;
            // 
            // TeacherAge
            // 
            this.TeacherAge.Location = new System.Drawing.Point(31, 157);
            this.TeacherAge.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherAge.Name = "TeacherAge";
            this.TeacherAge.Size = new System.Drawing.Size(282, 22);
            this.TeacherAge.TabIndex = 4;
            // 
            // TeacherSex
            // 
            this.TeacherSex.Location = new System.Drawing.Point(31, 217);
            this.TeacherSex.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherSex.Name = "TeacherSex";
            this.TeacherSex.Size = new System.Drawing.Size(282, 22);
            this.TeacherSex.TabIndex = 8;
            this.TeacherSex.TextChanged += new System.EventHandler(this.TeacherSex_TextChanged);
            // 
            // TeacherDiscipline
            // 
            this.TeacherDiscipline.Location = new System.Drawing.Point(31, 277);
            this.TeacherDiscipline.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherDiscipline.Name = "TeacherDiscipline";
            this.TeacherDiscipline.Size = new System.Drawing.Size(282, 22);
            this.TeacherDiscipline.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(31, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Курс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(31, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дисциплина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(31, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Пол:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(31, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возраст:";
            // 
            // TeacherCourse_Number
            // 
            this.TeacherCourse_Number.Location = new System.Drawing.Point(31, 337);
            this.TeacherCourse_Number.Name = "TeacherCourse_Number";
            this.TeacherCourse_Number.Size = new System.Drawing.Size(282, 22);
            this.TeacherCourse_Number.TabIndex = 18;
            // 
            // TeacherAddressHouse_Number
            // 
            this.TeacherAddressHouse_Number.Location = new System.Drawing.Point(31, 577);
            this.TeacherAddressHouse_Number.Name = "TeacherAddressHouse_Number";
            this.TeacherAddressHouse_Number.Size = new System.Drawing.Size(279, 22);
            this.TeacherAddressHouse_Number.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(31, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Страна:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(31, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Город:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(31, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Улица:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(31, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Номер дома:";
            // 
            // TeacherAddressCity
            // 
            this.TeacherAddressCity.Location = new System.Drawing.Point(31, 457);
            this.TeacherAddressCity.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherAddressCity.Name = "TeacherAddressCity";
            this.TeacherAddressCity.Size = new System.Drawing.Size(279, 22);
            this.TeacherAddressCity.TabIndex = 20;
            // 
            // TeacherAddressCountry
            // 
            this.TeacherAddressCountry.Location = new System.Drawing.Point(31, 397);
            this.TeacherAddressCountry.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherAddressCountry.Name = "TeacherAddressCountry";
            this.TeacherAddressCountry.Size = new System.Drawing.Size(279, 22);
            this.TeacherAddressCountry.TabIndex = 19;
            // 
            // TeacherAddressStreet
            // 
            this.TeacherAddressStreet.Location = new System.Drawing.Point(31, 517);
            this.TeacherAddressStreet.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherAddressStreet.Name = "TeacherAddressStreet";
            this.TeacherAddressStreet.Size = new System.Drawing.Size(279, 22);
            this.TeacherAddressStreet.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 688);
            this.Controls.Add(this.TeacherAddressHouse_Number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TeacherAddressCity);
            this.Controls.Add(this.TeacherAddressCountry);
            this.Controls.Add(this.TeacherAddressStreet);
            this.Controls.Add(this.TeacherCourse_Number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherSex);
            this.Controls.Add(this.TeacherAge);
            this.Controls.Add(this.TeacherSurname);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.AddTeacherButton);
            this.Controls.Add(this.TeacherDiscipline);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(373, 735);
            this.MinimumSize = new System.Drawing.Size(373, 735);
            this.Name = "Form2";
            this.Text = "Преподаватели";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.TextBox TeacherName;
        private System.Windows.Forms.TextBox TeacherSurname;
        private System.Windows.Forms.TextBox TeacherAge;
        private System.Windows.Forms.TextBox TeacherSex;
        private System.Windows.Forms.TextBox TeacherDiscipline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TeacherCourse_Number;
        private System.Windows.Forms.TextBox TeacherAddressHouse_Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TeacherAddressCity;
        private System.Windows.Forms.TextBox TeacherAddressCountry;
        private System.Windows.Forms.TextBox TeacherAddressStreet;
    }
}