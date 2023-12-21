namespace FileManager
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_DirrectoryPathLeft = new System.Windows.Forms.TextBox();
            this.comboBox_Left_Drives = new System.Windows.Forms.ComboBox();
            this.listView_left = new System.Windows.Forms.ListView();
            this.left_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.left_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.left_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.left_CreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back_Left_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_DirrectoryPathRight = new System.Windows.Forms.TextBox();
            this.comboBox_Right_Drives = new System.Windows.Forms.ComboBox();
            this.listView_right = new System.Windows.Forms.ListView();
            this.right_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.right_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.right_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.right_CreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.right_LastUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back_Right_button = new System.Windows.Forms.Button();
            this.left_LastUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_CreateFolderLeft = new System.Windows.Forms.Button();
            this.button_CreateFolderRight = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_CreateFolderLeft);
            this.panel1.Controls.Add(this.textBox_DirrectoryPathLeft);
            this.panel1.Controls.Add(this.comboBox_Left_Drives);
            this.panel1.Controls.Add(this.listView_left);
            this.panel1.Controls.Add(this.Back_Left_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 287);
            this.panel1.TabIndex = 0;
            // 
            // textBox_DirrectoryPathLeft
            // 
            this.textBox_DirrectoryPathLeft.Location = new System.Drawing.Point(3, 41);
            this.textBox_DirrectoryPathLeft.Name = "textBox_DirrectoryPathLeft";
            this.textBox_DirrectoryPathLeft.Size = new System.Drawing.Size(653, 20);
            this.textBox_DirrectoryPathLeft.TabIndex = 4;
            // 
            // comboBox_Left_Drives
            // 
            this.comboBox_Left_Drives.FormattingEnabled = true;
            this.comboBox_Left_Drives.Location = new System.Drawing.Point(32, 14);
            this.comboBox_Left_Drives.Name = "comboBox_Left_Drives";
            this.comboBox_Left_Drives.Size = new System.Drawing.Size(58, 21);
            this.comboBox_Left_Drives.TabIndex = 3;
            this.comboBox_Left_Drives.SelectedIndexChanged += new System.EventHandler(this.comboBox_Left_Drives_SelectedIndexChanged);
            // 
            // listView_left
            // 
            this.listView_left.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.left_Name,
            this.left_Size,
            this.left_Type,
            this.left_CreationDate,
            this.left_LastUpdate});
            this.listView_left.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_left.HideSelection = false;
            this.listView_left.Location = new System.Drawing.Point(0, 67);
            this.listView_left.Name = "listView_left";
            this.listView_left.Size = new System.Drawing.Size(699, 220);
            this.listView_left.TabIndex = 2;
            this.listView_left.UseCompatibleStateImageBehavior = false;
            this.listView_left.View = System.Windows.Forms.View.Details;
            this.listView_left.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_left_AfterLabelEdit);
            this.listView_left.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Left_ItemSelectionChanged);
            this.listView_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_left_MouseClick);
            this.listView_left.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Left_MouseDoubleClick);
            // 
            // left_Name
            // 
            this.left_Name.Text = "File name";
            this.left_Name.Width = 220;
            // 
            // left_Size
            // 
            this.left_Size.Text = "Size";
            this.left_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.left_Size.Width = 71;
            // 
            // left_Type
            // 
            this.left_Type.Text = "Type";
            this.left_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.left_Type.Width = 83;
            // 
            // left_CreationDate
            // 
            this.left_CreationDate.Text = "Creation date";
            this.left_CreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.left_CreationDate.Width = 117;
            // 
            // Back_Left_button
            // 
            this.Back_Left_button.AutoSize = true;
            this.Back_Left_button.Location = new System.Drawing.Point(3, 12);
            this.Back_Left_button.Name = "Back_Left_button";
            this.Back_Left_button.Size = new System.Drawing.Size(23, 23);
            this.Back_Left_button.TabIndex = 1;
            this.Back_Left_button.Text = "<";
            this.Back_Left_button.UseVisualStyleBackColor = true;
            this.Back_Left_button.Click += new System.EventHandler(this.left_button_Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_CreateFolderRight);
            this.panel2.Controls.Add(this.textBox_DirrectoryPathRight);
            this.panel2.Controls.Add(this.comboBox_Right_Drives);
            this.panel2.Controls.Add(this.listView_right);
            this.panel2.Controls.Add(this.Back_Right_button);
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 323);
            this.panel2.TabIndex = 1;
            // 
            // textBox_DirrectoryPathRight
            // 
            this.textBox_DirrectoryPathRight.Location = new System.Drawing.Point(3, 41);
            this.textBox_DirrectoryPathRight.Name = "textBox_DirrectoryPathRight";
            this.textBox_DirrectoryPathRight.Size = new System.Drawing.Size(653, 20);
            this.textBox_DirrectoryPathRight.TabIndex = 4;
            // 
            // comboBox_Right_Drives
            // 
            this.comboBox_Right_Drives.FormattingEnabled = true;
            this.comboBox_Right_Drives.Location = new System.Drawing.Point(32, 14);
            this.comboBox_Right_Drives.Name = "comboBox_Right_Drives";
            this.comboBox_Right_Drives.Size = new System.Drawing.Size(58, 21);
            this.comboBox_Right_Drives.TabIndex = 3;
            this.comboBox_Right_Drives.SelectedIndexChanged += new System.EventHandler(this.comboBox_Right_Drives_SelectedIndexChanged);
            // 
            // listView_right
            // 
            this.listView_right.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.right_Name,
            this.right_Size,
            this.right_Type,
            this.right_CreationDate,
            this.right_LastUpdate});
            this.listView_right.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_right.HideSelection = false;
            this.listView_right.Location = new System.Drawing.Point(0, 67);
            this.listView_right.Name = "listView_right";
            this.listView_right.Size = new System.Drawing.Size(699, 256);
            this.listView_right.TabIndex = 2;
            this.listView_right.UseCompatibleStateImageBehavior = false;
            this.listView_right.View = System.Windows.Forms.View.Details;
            this.listView_right.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_right_AfterLabelEdit);
            this.listView_right.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Right_ItemSelectionChanged);
            this.listView_right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_right_MouseClick);
            this.listView_right.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Right_MouseDoubleClick);
            // 
            // right_Name
            // 
            this.right_Name.Text = "File name";
            this.right_Name.Width = 221;
            // 
            // right_Size
            // 
            this.right_Size.Text = "Size";
            this.right_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.right_Size.Width = 77;
            // 
            // right_Type
            // 
            this.right_Type.Text = "Type";
            this.right_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.right_Type.Width = 71;
            // 
            // right_CreationDate
            // 
            this.right_CreationDate.Text = "Creation date";
            this.right_CreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.right_CreationDate.Width = 123;
            // 
            // right_LastUpdate
            // 
            this.right_LastUpdate.Text = "Last update";
            this.right_LastUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.right_LastUpdate.Width = 121;
            // 
            // Back_Right_button
            // 
            this.Back_Right_button.AutoSize = true;
            this.Back_Right_button.Location = new System.Drawing.Point(3, 12);
            this.Back_Right_button.Name = "Back_Right_button";
            this.Back_Right_button.Size = new System.Drawing.Size(23, 23);
            this.Back_Right_button.TabIndex = 1;
            this.Back_Right_button.Text = "<";
            this.Back_Right_button.UseVisualStyleBackColor = true;
            this.Back_Right_button.Click += new System.EventHandler(this.right_button_Back_Click);
            // 
            // left_LastUpdate
            // 
            this.left_LastUpdate.Text = "Last update";
            this.left_LastUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.left_LastUpdate.Width = 122;
            // 
            // button_CreateFolderLeft
            // 
            this.button_CreateFolderLeft.Location = new System.Drawing.Point(662, 39);
            this.button_CreateFolderLeft.Name = "button_CreateFolderLeft";
            this.button_CreateFolderLeft.Size = new System.Drawing.Size(34, 23);
            this.button_CreateFolderLeft.TabIndex = 5;
            this.button_CreateFolderLeft.Text = "+";
            this.button_CreateFolderLeft.UseVisualStyleBackColor = true;
            this.button_CreateFolderLeft.Click += new System.EventHandler(this.button_CreateFolderLeft_Click);
            // 
            // button_CreateFolderRight
            // 
            this.button_CreateFolderRight.Location = new System.Drawing.Point(662, 39);
            this.button_CreateFolderRight.Name = "button_CreateFolderRight";
            this.button_CreateFolderRight.Size = new System.Drawing.Size(34, 23);
            this.button_CreateFolderRight.TabIndex = 6;
            this.button_CreateFolderRight.Text = "+";
            this.button_CreateFolderRight.UseVisualStyleBackColor = true;
            this.button_CreateFolderRight.Click += new System.EventHandler(this.button_CreateFolderRight_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "File manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_Left_button;
        private System.Windows.Forms.TextBox textBox_DirrectoryPathLeft;
        private System.Windows.Forms.ComboBox comboBox_Left_Drives;
        private System.Windows.Forms.ListView listView_left;
        private System.Windows.Forms.ColumnHeader left_Name;
        private System.Windows.Forms.ColumnHeader left_Size;
        private System.Windows.Forms.ColumnHeader left_Type;
        private System.Windows.Forms.ColumnHeader left_CreationDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_DirrectoryPathRight;
        private System.Windows.Forms.ComboBox comboBox_Right_Drives;
        private System.Windows.Forms.ListView listView_right;
        private System.Windows.Forms.ColumnHeader right_Name;
        private System.Windows.Forms.ColumnHeader right_Size;
        private System.Windows.Forms.ColumnHeader right_Type;
        private System.Windows.Forms.ColumnHeader right_CreationDate;
        private System.Windows.Forms.ColumnHeader right_LastUpdate;
        private System.Windows.Forms.Button Back_Right_button;
        private System.Windows.Forms.ColumnHeader left_LastUpdate;
        private System.Windows.Forms.Button button_CreateFolderLeft;
        private System.Windows.Forms.Button button_CreateFolderRight;
    }
}

