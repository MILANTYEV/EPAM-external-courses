namespace Task1
{
    partial class FormAddOrEditUser
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
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.cmbBoxDay = new System.Windows.Forms.ComboBox();
            this.cmbBoxMonth = new System.Windows.Forms.ComboBox();
            this.cmbBoxYear = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAcceptChanges = new System.Windows.Forms.Button();
            this.labelPrizes = new System.Windows.Forms.Label();
            this.textBoxPrizes = new System.Windows.Forms.TextBox();
            this.buttonAddPrize = new System.Windows.Forms.Button();
            this.timerRefreshPrizes = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(88, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(12, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(88, 20);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBirthDate.Location = new System.Drawing.Point(12, 139);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(82, 20);
            this.LabelBirthDate.TabIndex = 2;
            this.LabelBirthDate.Text = "Birth date:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(129, 23);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(128, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(129, 66);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(128, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // cmbBoxDay
            // 
            this.cmbBoxDay.FormattingEnabled = true;
            this.cmbBoxDay.Location = new System.Drawing.Point(139, 141);
            this.cmbBoxDay.Name = "cmbBoxDay";
            this.cmbBoxDay.Size = new System.Drawing.Size(40, 21);
            this.cmbBoxDay.TabIndex = 5;
            // 
            // cmbBoxMonth
            // 
            this.cmbBoxMonth.FormattingEnabled = true;
            this.cmbBoxMonth.Location = new System.Drawing.Point(228, 141);
            this.cmbBoxMonth.Name = "cmbBoxMonth";
            this.cmbBoxMonth.Size = new System.Drawing.Size(40, 21);
            this.cmbBoxMonth.TabIndex = 6;
            // 
            // cmbBoxYear
            // 
            this.cmbBoxYear.FormattingEnabled = true;
            this.cmbBoxYear.Location = new System.Drawing.Point(309, 139);
            this.cmbBoxYear.Name = "cmbBoxYear";
            this.cmbBoxYear.Size = new System.Drawing.Size(53, 21);
            this.cmbBoxYear.TabIndex = 7;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(107, 146);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(26, 13);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "Day";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(185, 147);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(37, 13);
            this.labelMonth.TabIndex = 9;
            this.labelMonth.Text = "Month";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(274, 146);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 38);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAcceptChanges
            // 
            this.buttonAcceptChanges.Location = new System.Drawing.Point(110, 195);
            this.buttonAcceptChanges.Name = "buttonAcceptChanges";
            this.buttonAcceptChanges.Size = new System.Drawing.Size(91, 38);
            this.buttonAcceptChanges.TabIndex = 12;
            this.buttonAcceptChanges.Text = "Accept Changes";
            this.buttonAcceptChanges.UseVisualStyleBackColor = true;
            this.buttonAcceptChanges.Click += new System.EventHandler(this.buttonAcceptChanges_Click);
            // 
            // labelPrizes
            // 
            this.labelPrizes.AutoSize = true;
            this.labelPrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrizes.Location = new System.Drawing.Point(12, 102);
            this.labelPrizes.Name = "labelPrizes";
            this.labelPrizes.Size = new System.Drawing.Size(56, 20);
            this.labelPrizes.TabIndex = 13;
            this.labelPrizes.Text = "Prizes:";
            // 
            // textBoxPrizes
            // 
            this.textBoxPrizes.Location = new System.Drawing.Point(129, 101);
            this.textBoxPrizes.Name = "textBoxPrizes";
            this.textBoxPrizes.ReadOnly = true;
            this.textBoxPrizes.Size = new System.Drawing.Size(174, 20);
            this.textBoxPrizes.TabIndex = 14;
            // 
            // buttonAddPrize
            // 
            this.buttonAddPrize.Location = new System.Drawing.Point(309, 93);
            this.buttonAddPrize.Name = "buttonAddPrize";
            this.buttonAddPrize.Size = new System.Drawing.Size(68, 35);
            this.buttonAddPrize.TabIndex = 15;
            this.buttonAddPrize.Text = "Add prize";
            this.buttonAddPrize.UseVisualStyleBackColor = true;
            this.buttonAddPrize.Click += new System.EventHandler(this.buttonAddPrize_Click);
            // 
            // timerRefreshPrizes
            // 
            this.timerRefreshPrizes.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // FormAddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.buttonAddPrize);
            this.Controls.Add(this.textBoxPrizes);
            this.Controls.Add(this.labelPrizes);
            this.Controls.Add(this.buttonAcceptChanges);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.cmbBoxYear);
            this.Controls.Add(this.cmbBoxMonth);
            this.Controls.Add(this.cmbBoxDay);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.LabelBirthDate);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "FormAddOrEditUser";
            this.Text = "Add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label LabelBirthDate;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox cmbBoxDay;
        private System.Windows.Forms.ComboBox cmbBoxMonth;
        private System.Windows.Forms.ComboBox cmbBoxYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAcceptChanges;
        private System.Windows.Forms.Label labelPrizes;
        private System.Windows.Forms.TextBox textBoxPrizes;
        private System.Windows.Forms.Button buttonAddPrize;
        private System.Windows.Forms.Timer timerRefreshPrizes;
    }
}