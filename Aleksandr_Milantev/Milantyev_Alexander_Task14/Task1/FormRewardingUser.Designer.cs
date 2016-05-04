namespace Task1
{
    partial class FormRewardingUser
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
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridPrizes = new System.Windows.Forms.DataGridView();
            this.buttonAddPrizeToUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrizes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(13, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(54, 24);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User:";
            // 
            // dataGridPrizes
            // 
            this.dataGridPrizes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridPrizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrizes.Location = new System.Drawing.Point(2, 41);
            this.dataGridPrizes.Name = "dataGridPrizes";
            this.dataGridPrizes.Size = new System.Drawing.Size(395, 177);
            this.dataGridPrizes.TabIndex = 1;
            // 
            // buttonAddPrizeToUser
            // 
            this.buttonAddPrizeToUser.Location = new System.Drawing.Point(12, 224);
            this.buttonAddPrizeToUser.Name = "buttonAddPrizeToUser";
            this.buttonAddPrizeToUser.Size = new System.Drawing.Size(100, 32);
            this.buttonAddPrizeToUser.TabIndex = 2;
            this.buttonAddPrizeToUser.Text = "Add Prize to User";
            this.buttonAddPrizeToUser.UseVisualStyleBackColor = true;
            this.buttonAddPrizeToUser.Click += new System.EventHandler(this.buttonAddPrizeToUser_Click);
            // 
            // FormRewardingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 265);
            this.Controls.Add(this.buttonAddPrizeToUser);
            this.Controls.Add(this.dataGridPrizes);
            this.Controls.Add(this.labelUser);
            this.Name = "FormRewardingUser";
            this.Text = "FormRewardingUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrizes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridPrizes;
        private System.Windows.Forms.Button buttonAddPrizeToUser;
    }
}