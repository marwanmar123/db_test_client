
namespace db_test_client
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
            this.dt_gridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_List = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_serach_c = new System.Windows.Forms.Button();
            this.btn_new_check = new System.Windows.Forms.Button();
            this.btn_edit_c = new System.Windows.Forms.Button();
            this.btn_delete_c = new System.Windows.Forms.Button();
            this.btn_add_c = new System.Windows.Forms.Button();
            this.id_Client = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_id_C = new System.Windows.Forms.TextBox();
            this.input_name_c = new System.Windows.Forms.TextBox();
            this.input_lName_c = new System.Windows.Forms.TextBox();
            this.input_mail_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_ville_c = new System.Windows.Forms.TextBox();
            this.input_srx_c = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_gridview
            // 
            this.dt_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.C_name,
            this.C_fname,
            this.mail,
            this.ville});
            this.dt_gridview.Location = new System.Drawing.Point(183, 319);
            this.dt_gridview.Name = "dt_gridview";
            this.dt_gridview.Size = new System.Drawing.Size(543, 200);
            this.dt_gridview.TabIndex = 0;
            this.dt_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_gridview_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            // 
            // C_name
            // 
            this.C_name.HeaderText = "C_name";
            this.C_name.Name = "C_name";
            // 
            // C_fname
            // 
            this.C_fname.HeaderText = "C_fname";
            this.C_fname.Name = "C_fname";
            // 
            // mail
            // 
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            // 
            // ville
            // 
            this.ville.HeaderText = "ville";
            this.ville.Name = "ville";
            // 
            // Client_List
            // 
            this.Client_List.Location = new System.Drawing.Point(57, 19);
            this.Client_List.Name = "Client_List";
            this.Client_List.Size = new System.Drawing.Size(75, 23);
            this.Client_List.TabIndex = 1;
            this.Client_List.Text = "list client";
            this.Client_List.UseVisualStyleBackColor = true;
            this.Client_List.Click += new System.EventHandler(this.Client_List_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_srx_c);
            this.groupBox1.Controls.Add(this.btn_serach_c);
            this.groupBox1.Controls.Add(this.btn_new_check);
            this.groupBox1.Controls.Add(this.btn_edit_c);
            this.groupBox1.Controls.Add(this.btn_delete_c);
            this.groupBox1.Controls.Add(this.btn_add_c);
            this.groupBox1.Controls.Add(this.Client_List);
            this.groupBox1.Location = new System.Drawing.Point(634, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "operations";
            // 
            // btn_serach_c
            // 
            this.btn_serach_c.Location = new System.Drawing.Point(156, 226);
            this.btn_serach_c.Name = "btn_serach_c";
            this.btn_serach_c.Size = new System.Drawing.Size(75, 23);
            this.btn_serach_c.TabIndex = 6;
            this.btn_serach_c.Text = "search";
            this.btn_serach_c.UseVisualStyleBackColor = true;
            this.btn_serach_c.Click += new System.EventHandler(this.btn_serach_c_Click);
            // 
            // btn_new_check
            // 
            this.btn_new_check.Location = new System.Drawing.Point(57, 178);
            this.btn_new_check.Name = "btn_new_check";
            this.btn_new_check.Size = new System.Drawing.Size(75, 23);
            this.btn_new_check.TabIndex = 5;
            this.btn_new_check.Text = "new";
            this.btn_new_check.UseVisualStyleBackColor = true;
            this.btn_new_check.Click += new System.EventHandler(this.btn_new_check_Click);
            // 
            // btn_edit_c
            // 
            this.btn_edit_c.Location = new System.Drawing.Point(57, 138);
            this.btn_edit_c.Name = "btn_edit_c";
            this.btn_edit_c.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_c.TabIndex = 4;
            this.btn_edit_c.Text = "edit";
            this.btn_edit_c.UseVisualStyleBackColor = true;
            this.btn_edit_c.Click += new System.EventHandler(this.btn_edit_c_Click);
            // 
            // btn_delete_c
            // 
            this.btn_delete_c.Location = new System.Drawing.Point(57, 97);
            this.btn_delete_c.Name = "btn_delete_c";
            this.btn_delete_c.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_c.TabIndex = 3;
            this.btn_delete_c.Text = "delete";
            this.btn_delete_c.UseVisualStyleBackColor = true;
            this.btn_delete_c.Click += new System.EventHandler(this.btn_delete_c_Click);
            // 
            // btn_add_c
            // 
            this.btn_add_c.Location = new System.Drawing.Point(57, 55);
            this.btn_add_c.Name = "btn_add_c";
            this.btn_add_c.Size = new System.Drawing.Size(75, 23);
            this.btn_add_c.TabIndex = 2;
            this.btn_add_c.Text = "add";
            this.btn_add_c.UseVisualStyleBackColor = true;
            this.btn_add_c.Click += new System.EventHandler(this.btn_add_c_Click);
            // 
            // id_Client
            // 
            this.id_Client.AutoSize = true;
            this.id_Client.Location = new System.Drawing.Point(174, 26);
            this.id_Client.Name = "id_Client";
            this.id_Client.Size = new System.Drawing.Size(15, 13);
            this.id_Client.TabIndex = 3;
            this.id_Client.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "name";
            // 
            // input_id_C
            // 
            this.input_id_C.Location = new System.Drawing.Point(196, 23);
            this.input_id_C.Name = "input_id_C";
            this.input_id_C.Size = new System.Drawing.Size(100, 20);
            this.input_id_C.TabIndex = 8;
            // 
            // input_name_c
            // 
            this.input_name_c.Location = new System.Drawing.Point(196, 85);
            this.input_name_c.Name = "input_name_c";
            this.input_name_c.Size = new System.Drawing.Size(100, 20);
            this.input_name_c.TabIndex = 9;
            // 
            // input_lName_c
            // 
            this.input_lName_c.Location = new System.Drawing.Point(397, 26);
            this.input_lName_c.Name = "input_lName_c";
            this.input_lName_c.Size = new System.Drawing.Size(100, 20);
            this.input_lName_c.TabIndex = 11;
            // 
            // input_mail_c
            // 
            this.input_mail_c.Location = new System.Drawing.Point(361, 112);
            this.input_mail_c.Name = "input_mail_c";
            this.input_mail_c.Size = new System.Drawing.Size(100, 20);
            this.input_mail_c.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "mail";
            // 
            // input_ville_c
            // 
            this.input_ville_c.Location = new System.Drawing.Point(205, 149);
            this.input_ville_c.Name = "input_ville_c";
            this.input_ville_c.Size = new System.Drawing.Size(100, 20);
            this.input_ville_c.TabIndex = 14;
            // 
            // input_srx_c
            // 
            this.input_srx_c.Location = new System.Drawing.Point(32, 229);
            this.input_srx_c.Name = "input_srx_c";
            this.input_srx_c.Size = new System.Drawing.Size(100, 20);
            this.input_srx_c.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 551);
            this.Controls.Add(this.input_ville_c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_mail_c);
            this.Controls.Add(this.input_lName_c);
            this.Controls.Add(this.input_name_c);
            this.Controls.Add(this.input_id_C);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_Client);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_gridview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.Button Client_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label id_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_id_C;
        private System.Windows.Forms.TextBox input_name_c;
        private System.Windows.Forms.TextBox input_lName_c;
        private System.Windows.Forms.TextBox input_mail_c;
        private System.Windows.Forms.Button btn_add_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_ville_c;
        private System.Windows.Forms.Button btn_delete_c;
        private System.Windows.Forms.Button btn_edit_c;
        private System.Windows.Forms.Button btn_new_check;
        private System.Windows.Forms.Button btn_serach_c;
        private System.Windows.Forms.TextBox input_srx_c;
    }
}

