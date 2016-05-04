namespace Task1
{
    partial class FormMain
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
            this.tabContUserPrizeSelection = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPagePrizes = new System.Windows.Forms.TabPage();
            this.dataGridViewPrizes = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddPrize = new System.Windows.Forms.Button();
            this.buttonAddPrizeToUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeletePrize = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditPrize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrizeToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPrizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePrizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContUserPrizeSelection.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPagePrizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrizes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContUserPrizeSelection
            // 
            this.tabContUserPrizeSelection.Controls.Add(this.tabPageUsers);
            this.tabContUserPrizeSelection.Controls.Add(this.tabPagePrizes);
            this.tabContUserPrizeSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabContUserPrizeSelection.Location = new System.Drawing.Point(0, 24);
            this.tabContUserPrizeSelection.Name = "tabContUserPrizeSelection";
            this.tabContUserPrizeSelection.SelectedIndex = 0;
            this.tabContUserPrizeSelection.Size = new System.Drawing.Size(520, 225);
            this.tabContUserPrizeSelection.TabIndex = 0;
            this.tabContUserPrizeSelection.SelectedIndexChanged += new System.EventHandler(this.tabContListSelection_SelectedIndexChanged);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(512, 199);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(506, 193);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUsers_ColumnHeaderMouseClick);
            // 
            // tabPagePrizes
            // 
            this.tabPagePrizes.Controls.Add(this.dataGridViewPrizes);
            this.tabPagePrizes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrizes.Name = "tabPagePrizes";
            this.tabPagePrizes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrizes.Size = new System.Drawing.Size(512, 199);
            this.tabPagePrizes.TabIndex = 1;
            this.tabPagePrizes.Text = "Prizes";
            this.tabPagePrizes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrizes
            // 
            this.dataGridViewPrizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrizes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPrizes.Name = "dataGridViewPrizes";
            this.dataGridViewPrizes.Size = new System.Drawing.Size(506, 193);
            this.dataGridViewPrizes.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(29, 237);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(94, 34);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddPrize
            // 
            this.buttonAddPrize.Location = new System.Drawing.Point(29, 237);
            this.buttonAddPrize.Name = "buttonAddPrize";
            this.buttonAddPrize.Size = new System.Drawing.Size(94, 34);
            this.buttonAddPrize.TabIndex = 2;
            this.buttonAddPrize.Text = "Add prize";
            this.buttonAddPrize.UseVisualStyleBackColor = true;
            this.buttonAddPrize.Visible = false;
            this.buttonAddPrize.Click += new System.EventHandler(this.buttonAddPrize_Click);
            // 
            // buttonAddPrizeToUser
            // 
            this.buttonAddPrizeToUser.Location = new System.Drawing.Point(329, 238);
            this.buttonAddPrizeToUser.Name = "buttonAddPrizeToUser";
            this.buttonAddPrizeToUser.Size = new System.Drawing.Size(94, 34);
            this.buttonAddPrizeToUser.TabIndex = 3;
            this.buttonAddPrizeToUser.Text = "Add Prize to user";
            this.buttonAddPrizeToUser.UseVisualStyleBackColor = true;
            this.buttonAddPrizeToUser.Click += new System.EventHandler(this.buttonAddPrizeToUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(229, 238);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(94, 35);
            this.buttonEditUser.TabIndex = 4;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonDeletePrize
            // 
            this.buttonDeletePrize.Location = new System.Drawing.Point(129, 237);
            this.buttonDeletePrize.Name = "buttonDeletePrize";
            this.buttonDeletePrize.Size = new System.Drawing.Size(94, 34);
            this.buttonDeletePrize.TabIndex = 5;
            this.buttonDeletePrize.Text = "Delete Prize";
            this.buttonDeletePrize.UseVisualStyleBackColor = true;
            this.buttonDeletePrize.Visible = false;
            this.buttonDeletePrize.Click += new System.EventHandler(this.buttonDeletePrize_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(129, 237);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(94, 34);
            this.buttonDeleteUser.TabIndex = 6;
            this.buttonDeleteUser.Text = "Delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonEditPrize
            // 
            this.buttonEditPrize.Location = new System.Drawing.Point(229, 239);
            this.buttonEditPrize.Name = "buttonEditPrize";
            this.buttonEditPrize.Size = new System.Drawing.Size(94, 34);
            this.buttonEditPrize.TabIndex = 7;
            this.buttonEditPrize.Text = "Edit Prize";
            this.buttonEditPrize.UseVisualStyleBackColor = true;
            this.buttonEditPrize.Visible = false;
            this.buttonEditPrize.Click += new System.EventHandler(this.buttonEditPrize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.prizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.addPrizeToUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "User";
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrizeToolStripMenuItem,
            this.editPrizeToolStripMenuItem,
            this.deletePrizeToolStripMenuItem});
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.prizeToolStripMenuItem.Text = "Prize";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editUserToolStripMenuItem.Text = "Edit user";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // addPrizeToUserToolStripMenuItem
            // 
            this.addPrizeToUserToolStripMenuItem.Name = "addPrizeToUserToolStripMenuItem";
            this.addPrizeToUserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addPrizeToUserToolStripMenuItem.Text = "Add prize to user";
            this.addPrizeToUserToolStripMenuItem.Click += new System.EventHandler(this.addPrizeToUserToolStripMenuItem_Click);
            // 
            // addPrizeToolStripMenuItem
            // 
            this.addPrizeToolStripMenuItem.Name = "addPrizeToolStripMenuItem";
            this.addPrizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPrizeToolStripMenuItem.Text = "Add prize";
            this.addPrizeToolStripMenuItem.Click += new System.EventHandler(this.addPrizeToolStripMenuItem_Click);
            // 
            // editPrizeToolStripMenuItem
            // 
            this.editPrizeToolStripMenuItem.Name = "editPrizeToolStripMenuItem";
            this.editPrizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editPrizeToolStripMenuItem.Text = "Edit prize";
            this.editPrizeToolStripMenuItem.Click += new System.EventHandler(this.editPrizeToolStripMenuItem_Click);
            // 
            // deletePrizeToolStripMenuItem
            // 
            this.deletePrizeToolStripMenuItem.Name = "deletePrizeToolStripMenuItem";
            this.deletePrizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deletePrizeToolStripMenuItem.Text = "Delete prize";
            this.deletePrizeToolStripMenuItem.Click += new System.EventHandler(this.deletePrizeToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 285);
            this.Controls.Add(this.buttonEditPrize);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonDeletePrize);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonAddPrizeToUser);
            this.Controls.Add(this.buttonAddPrize);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.tabContUserPrizeSelection);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabContUserPrizeSelection.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPagePrizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrizes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContUserPrizeSelection;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPagePrizes;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridView dataGridViewPrizes;
        private System.Windows.Forms.Button buttonAddPrize;
        private System.Windows.Forms.Button buttonAddPrizeToUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonDeletePrize;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditPrize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrizeToUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPrizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePrizeToolStripMenuItem;
    }
}

