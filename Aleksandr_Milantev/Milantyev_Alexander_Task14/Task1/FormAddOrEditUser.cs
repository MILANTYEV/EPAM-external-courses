using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormAddOrEditUser : Form
    {
        private const int MAX_AGE = 150;

        FormMain _mainForm;
        User _user;
        
        public FormAddOrEditUser(FormMain mainForm)
        {
            this._mainForm = mainForm;
            this._user = null;
            InitializeComponent();
            buttonAcceptChanges.Visible = false;
            InitializeDateComboBoxes();
            
        }

        public FormAddOrEditUser(FormMain mainForm, User editableUser)
        {
            this._mainForm = mainForm;
            this._user = editableUser;
            InitializeComponent();
            this.Text = "Edit user";
            buttonAdd.Visible = false;
            InitializeDateComboBoxes();
            textBoxFirstName.Text = _user.FirstName;
            textBoxLastName.Text = _user.LastName;
            textBoxPrizes.Text = _user.Prizes;
            cmbBoxDay.SelectedItem = _user.BirthDate.Day;
            cmbBoxMonth.SelectedItem = _user.BirthDate.Month;
            cmbBoxYear.SelectedItem = _user.BirthDate.Year;
        }

        private void InitializeDateComboBoxes()
        {
            for (int i = 1; i <= 31; i++)
            {
                cmbBoxDay.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cmbBoxMonth.Items.Add(i);
            }
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - MAX_AGE; i--)
            {
                cmbBoxYear.Items.Add(i);
            }
        }
        
        private void CreateUser()
        {
            _user = new User(CalculateNewID(), textBoxFirstName.Text, textBoxLastName.Text,
                    new DateTime((int)cmbBoxYear.SelectedItem, (int)cmbBoxMonth.SelectedItem, (int)cmbBoxDay.SelectedItem));
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user == null)
                {
                    CreateUser();
                }
                _mainForm.UsersBindList.Add(_user);
                MessageBox.Show("User is added.");
                this.Dispose();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Not all date-fields are field");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Not all name-fields are field");
            }
        }

        private int CalculateNewID()
        {
            int lastId = 1;
            foreach (var user in _mainForm.UsersBindList)
            {
                if (user.ID > lastId)
                {
                    lastId = user.ID;
                }
            }
            return lastId + 1;
        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            try
            {
                int index = _mainForm.UsersBindList.IndexOf(_user);
                _mainForm.UsersBindList[index].FirstName = textBoxFirstName.Text;
                _mainForm.UsersBindList[index].LastName = textBoxLastName.Text;
                _mainForm.UsersBindList[index].BirthDate = new DateTime((int)cmbBoxYear.SelectedItem,
                    (int)cmbBoxMonth.SelectedItem, (int)cmbBoxDay.SelectedItem);
                MessageBox.Show("Changes accepted");
                this.Dispose();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Check the date-fields");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Not all name-fields are field");
            }
        }

        private void buttonAddPrize_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user == null)
                {
                    CreateUser();
                }
                FormRewardingUser rewardingForm = new FormRewardingUser(_mainForm, _user);
                rewardingForm.Show();
                timerRefreshPrizes.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            textBoxPrizes.Text = _user.Prizes;
        }
    }
}
