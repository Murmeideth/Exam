
namespace Demo
{
    partial class Personal
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
            this.list = new System.Windows.Forms.DataGridView();
            this.del_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.clear_search = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(13, 13);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(688, 303);
            this.list.TabIndex = 0;
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(498, 320);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(95, 29);
            this.del_btn.TabIndex = 1;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chng_btn.Location = new System.Drawing.Point(599, 354);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(102, 29);
            this.chng_btn.TabIndex = 2;
            this.chng_btn.Text = "Изменить";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(599, 319);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 29);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_box.Location = new System.Drawing.Point(12, 321);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(204, 26);
            this.search_box.TabIndex = 4;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // clear_search
            // 
            this.clear_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_search.Location = new System.Drawing.Point(222, 321);
            this.clear_search.Name = "clear_search";
            this.clear_search.Size = new System.Drawing.Size(93, 26);
            this.clear_search.TabIndex = 5;
            this.clear_search.Text = "Сбросить";
            this.clear_search.UseVisualStyleBackColor = true;
            this.clear_search.Click += new System.EventHandler(this.clear_search_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(498, 356);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(95, 27);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 412);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_search);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Personal";
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button clear_search;
        private System.Windows.Forms.Button exit_btn;
    }
}