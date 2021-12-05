
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddStudentButton_Click = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentSurname = new System.Windows.Forms.TextBox();
            this.StudentAge = new System.Windows.Forms.TextBox();
            this.StudentSex = new System.Windows.Forms.TextBox();
            this.StudentGroup = new System.Windows.Forms.TextBox();
            this.StudentFaculty = new System.Windows.Forms.TextBox();
            this.StudentAddressCountry = new System.Windows.Forms.TextBox();
            this.StudentAddressCity = new System.Windows.Forms.TextBox();
            this.StudentAddressStreet = new System.Windows.Forms.TextBox();
            this.StudentAddressHouseNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(31, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(31, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Группа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(31, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Факультет:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(31, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Страна:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(31, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Город:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(31, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Улица:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(31, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Номер дома:";
            // 
            // AddStudentButton_Click
            // 
            this.AddStudentButton_Click.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.AddStudentButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentButton_Click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddStudentButton_Click.Location = new System.Drawing.Point(31, 622);
            this.AddStudentButton_Click.Name = "AddStudentButton_Click";
            this.AddStudentButton_Click.Size = new System.Drawing.Size(279, 53);
            this.AddStudentButton_Click.TabIndex = 10;
            this.AddStudentButton_Click.Text = "Добавить студента";
            this.AddStudentButton_Click.UseVisualStyleBackColor = false;
            this.AddStudentButton_Click.Click += new System.EventHandler(this.AddStudentButton_Click_Click);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(31, 37);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(282, 22);
            this.StudentName.TabIndex = 11;
            // 
            // StudentSurname
            // 
            this.StudentSurname.Location = new System.Drawing.Point(31, 97);
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.Size = new System.Drawing.Size(282, 22);
            this.StudentSurname.TabIndex = 12;
            // 
            // StudentAge
            // 
            this.StudentAge.Location = new System.Drawing.Point(31, 157);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(282, 22);
            this.StudentAge.TabIndex = 13;
            // 
            // StudentSex
            // 
            this.StudentSex.Location = new System.Drawing.Point(31, 217);
            this.StudentSex.Name = "StudentSex";
            this.StudentSex.Size = new System.Drawing.Size(282, 22);
            this.StudentSex.TabIndex = 14;
            // 
            // StudentGroup
            // 
            this.StudentGroup.Location = new System.Drawing.Point(31, 277);
            this.StudentGroup.Name = "StudentGroup";
            this.StudentGroup.Size = new System.Drawing.Size(282, 22);
            this.StudentGroup.TabIndex = 15;
            // 
            // StudentFaculty
            // 
            this.StudentFaculty.Location = new System.Drawing.Point(31, 337);
            this.StudentFaculty.Name = "StudentFaculty";
            this.StudentFaculty.Size = new System.Drawing.Size(282, 22);
            this.StudentFaculty.TabIndex = 16;
            // 
            // StudentAddressCountry
            // 
            this.StudentAddressCountry.Location = new System.Drawing.Point(31, 397);
            this.StudentAddressCountry.Name = "StudentAddressCountry";
            this.StudentAddressCountry.Size = new System.Drawing.Size(282, 22);
            this.StudentAddressCountry.TabIndex = 17;
            // 
            // StudentAddressCity
            // 
            this.StudentAddressCity.Location = new System.Drawing.Point(31, 457);
            this.StudentAddressCity.Name = "StudentAddressCity";
            this.StudentAddressCity.Size = new System.Drawing.Size(282, 22);
            this.StudentAddressCity.TabIndex = 18;
            // 
            // StudentAddressStreet
            // 
            this.StudentAddressStreet.Location = new System.Drawing.Point(31, 517);
            this.StudentAddressStreet.Name = "StudentAddressStreet";
            this.StudentAddressStreet.Size = new System.Drawing.Size(282, 22);
            this.StudentAddressStreet.TabIndex = 19;
            // 
            // StudentAddressHouseNumber
            // 
            this.StudentAddressHouseNumber.Location = new System.Drawing.Point(31, 577);
            this.StudentAddressHouseNumber.Name = "StudentAddressHouseNumber";
            this.StudentAddressHouseNumber.Size = new System.Drawing.Size(282, 22);
            this.StudentAddressHouseNumber.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 688);
            this.Controls.Add(this.StudentAddressHouseNumber);
            this.Controls.Add(this.StudentAddressStreet);
            this.Controls.Add(this.StudentAddressCity);
            this.Controls.Add(this.StudentAddressCountry);
            this.Controls.Add(this.StudentFaculty);
            this.Controls.Add(this.StudentGroup);
            this.Controls.Add(this.StudentSex);
            this.Controls.Add(this.StudentAge);
            this.Controls.Add(this.StudentSurname);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.AddStudentButton_Click);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Студенты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddStudentButton_Click;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentSurname;
        private System.Windows.Forms.TextBox StudentAge;
        private System.Windows.Forms.TextBox StudentSex;
        private System.Windows.Forms.TextBox StudentGroup;
        private System.Windows.Forms.TextBox StudentFaculty;
        private System.Windows.Forms.TextBox StudentAddressCountry;
        private System.Windows.Forms.TextBox StudentAddressCity;
        private System.Windows.Forms.TextBox StudentAddressStreet;
        private System.Windows.Forms.TextBox StudentAddressHouseNumber;
    }
}