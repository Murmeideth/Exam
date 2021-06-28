
namespace Demo
{
    partial class AddNChange
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.sex_box = new System.Windows.Forms.ComboBox();
            this.phone_box = new System.Windows.Forms.MaskedTextBox();
            this.mail_box = new System.Windows.Forms.TextBox();
            this.bio_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.education_box = new System.Windows.Forms.ComboBox();
            this.position_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(12, 34);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(177, 26);
            this.name_box.TabIndex = 0;
            // 
            // sex_box
            // 
            this.sex_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex_box.FormattingEnabled = true;
            this.sex_box.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.sex_box.Location = new System.Drawing.Point(12, 83);
            this.sex_box.Name = "sex_box";
            this.sex_box.Size = new System.Drawing.Size(177, 27);
            this.sex_box.TabIndex = 1;
            // 
            // phone_box
            // 
            this.phone_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_box.Location = new System.Drawing.Point(12, 176);
            this.phone_box.Mask = "+0-000-000-00-00";
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(177, 26);
            this.phone_box.TabIndex = 3;
            // 
            // mail_box
            // 
            this.mail_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail_box.Location = new System.Drawing.Point(12, 225);
            this.mail_box.Name = "mail_box";
            this.mail_box.Size = new System.Drawing.Size(177, 26);
            this.mail_box.TabIndex = 4;
            // 
            // bio_box
            // 
            this.bio_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bio_box.Location = new System.Drawing.Point(205, 62);
            this.bio_box.Name = "bio_box";
            this.bio_box.Size = new System.Drawing.Size(268, 238);
            this.bio_box.TabIndex = 7;
            this.bio_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Образование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Должность";
            // 
            // education_box
            // 
            this.education_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.education_box.FormattingEnabled = true;
            this.education_box.Items.AddRange(new object[] {
            "Общее",
            "Общее среднее",
            "Средне-специальное",
            "Средне-профессиональное",
            "Высшее",
            "Магистратура",
            "Доктор"});
            this.education_box.Location = new System.Drawing.Point(12, 131);
            this.education_box.Name = "education_box";
            this.education_box.Size = new System.Drawing.Size(177, 27);
            this.education_box.TabIndex = 1;
            // 
            // position_box
            // 
            this.position_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_box.FormattingEnabled = true;
            this.position_box.Items.AddRange(new object[] {
            "Актёр",
            "Актриса",
            "Дворник",
            "Танцор",
            "Фазик-теоретик",
            "Автогонщик",
            "Канцлер",
            "Певица"});
            this.position_box.Location = new System.Drawing.Point(12, 273);
            this.position_box.Name = "position_box";
            this.position_box.Size = new System.Drawing.Size(177, 27);
            this.position_box.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(202, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "О себе";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(385, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(291, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bio_box);
            this.Controls.Add(this.mail_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.position_box);
            this.Controls.Add(this.education_box);
            this.Controls.Add(this.sex_box);
            this.Controls.Add(this.name_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNChange";
            this.Text = "AddNChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox sex_box;
        private System.Windows.Forms.MaskedTextBox phone_box;
        private System.Windows.Forms.TextBox mail_box;
        private System.Windows.Forms.RichTextBox bio_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox education_box;
        private System.Windows.Forms.ComboBox position_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}