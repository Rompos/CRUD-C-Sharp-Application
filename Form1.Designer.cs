
namespace CRUD_Application_C_SHARP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.Populationtxt = new System.Windows.Forms.TextBox();
            this.Districttxt = new System.Windows.Forms.TextBox();
            this.CountryCodetxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.u_Populationtxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.u_IDtxt = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.u_Nametxt = new System.Windows.Forms.TextBox();
            this.u_CountryCodetxt = new System.Windows.Forms.TextBox();
            this.u_Districttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.Populationtxt);
            this.groupBox1.Controls.Add(this.Districttxt);
            this.groupBox1.Controls.Add(this.CountryCodetxt);
            this.groupBox1.Controls.Add(this.Nametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(6, 193);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 14;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(186, 193);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "CREATE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Populationtxt
            // 
            this.Populationtxt.BackColor = System.Drawing.SystemColors.Window;
            this.Populationtxt.Location = new System.Drawing.Point(92, 150);
            this.Populationtxt.Name = "Populationtxt";
            this.Populationtxt.Size = new System.Drawing.Size(169, 23);
            this.Populationtxt.TabIndex = 12;
            // 
            // Districttxt
            // 
            this.Districttxt.BackColor = System.Drawing.SystemColors.Window;
            this.Districttxt.Location = new System.Drawing.Point(92, 121);
            this.Districttxt.Name = "Districttxt";
            this.Districttxt.Size = new System.Drawing.Size(169, 23);
            this.Districttxt.TabIndex = 11;
            // 
            // CountryCodetxt
            // 
            this.CountryCodetxt.BackColor = System.Drawing.SystemColors.Window;
            this.CountryCodetxt.Location = new System.Drawing.Point(92, 86);
            this.CountryCodetxt.Name = "CountryCodetxt";
            this.CountryCodetxt.Size = new System.Drawing.Size(169, 23);
            this.CountryCodetxt.TabIndex = 10;
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.SystemColors.Window;
            this.Nametxt.Location = new System.Drawing.Point(92, 50);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(169, 23);
            this.Nametxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Population";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "District";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // u_Populationtxt
            // 
            this.u_Populationtxt.BackColor = System.Drawing.SystemColors.Window;
            this.u_Populationtxt.Location = new System.Drawing.Point(129, 150);
            this.u_Populationtxt.Name = "u_Populationtxt";
            this.u_Populationtxt.Size = new System.Drawing.Size(169, 23);
            this.u_Populationtxt.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "READ / VIEW DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(693, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.u_IDtxt);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.u_Nametxt);
            this.groupBox3.Controls.Add(this.u_CountryCodetxt);
            this.groupBox3.Controls.Add(this.u_Districttxt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.u_Populationtxt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(413, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 222);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UPDATE / DELETE";
            // 
            // u_IDtxt
            // 
            this.u_IDtxt.BackColor = System.Drawing.SystemColors.Window;
            this.u_IDtxt.Location = new System.Drawing.Point(130, 16);
            this.u_IDtxt.Name = "u_IDtxt";
            this.u_IDtxt.Size = new System.Drawing.Size(169, 23);
            this.u_IDtxt.TabIndex = 15;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(223, 193);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(22, 193);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // u_Nametxt
            // 
            this.u_Nametxt.BackColor = System.Drawing.SystemColors.Window;
            this.u_Nametxt.Location = new System.Drawing.Point(129, 42);
            this.u_Nametxt.Name = "u_Nametxt";
            this.u_Nametxt.Size = new System.Drawing.Size(169, 23);
            this.u_Nametxt.TabIndex = 14;
            // 
            // u_CountryCodetxt
            // 
            this.u_CountryCodetxt.BackColor = System.Drawing.SystemColors.Window;
            this.u_CountryCodetxt.Location = new System.Drawing.Point(129, 78);
            this.u_CountryCodetxt.Name = "u_CountryCodetxt";
            this.u_CountryCodetxt.Size = new System.Drawing.Size(169, 23);
            this.u_CountryCodetxt.TabIndex = 13;
            // 
            // u_Districttxt
            // 
            this.u_Districttxt.BackColor = System.Drawing.SystemColors.Window;
            this.u_Districttxt.Location = new System.Drawing.Point(129, 113);
            this.u_Districttxt.Name = "u_Districttxt";
            this.u_Districttxt.Size = new System.Drawing.Size(169, 23);
            this.u_Districttxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Population";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2158, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Population";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "District";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(307, 106);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 60);
            this.label11.TabIndex = 3;
            this.label11.Text = "C = CREATE\r\nR = READ\r\nU = UPDATE\r\nD = DELETE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CRUD C# By Stratos Rompos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.TextBox u_Populationtxt;
        private System.Windows.Forms.TextBox Populationtxt;
        private System.Windows.Forms.TextBox Districttxt;
        private System.Windows.Forms.TextBox CountryCodetxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox u_Districttxt;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.TextBox u_Nametxt;
        private System.Windows.Forms.TextBox u_CountryCodetxt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox u_IDtxt;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label11;
    }
}

