using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;

namespace Task1
{
    public partial class FormMain : Form
    {
        public UsersBL UsersBusinessLogic { get; set; }
        public PrizesBL PrizesBusinessLogic { get; set; }
        public BindingList<User> UsersBindList { get; set; }
        public BindingList<Prize> PrizesBindList { get; set; }
        
        public FormMain()
        {
            UsersBusinessLogic = new UsersBL();
            PrizesBusinessLogic = new PrizesBL();
            UsersBindList = new BindingList<User>(UsersBusinessLogic.InitList().ToList());
            PrizesBindList = new BindingList<Prize>(PrizesBusinessLogic.InitList().ToList());
            InitializeComponent();
            dataGridViewUsers.DataSource = UsersBindList;
            dataGridViewPrizes.DataSource = PrizesBindList;
            dataGridViewUsers.Columns["Prizes"].DisplayIndex = 5;
        }

        private void AddUser()
        {
            FormAddOrEditUser formAddUser = new FormAddOrEditUser(this);
            formAddUser.Show();
        }
        
        private void EditUser()
        {
            User user = (User)dataGridViewUsers.SelectedCells[0].OwningRow.DataBoundItem;
            FormAddOrEditUser formEditUser = new FormAddOrEditUser(this, user);
            formEditUser.Show();
        }

        private void DeleteUser()
        {
            User deletedUser = (User)dataGridViewUsers.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialog = MessageBox.Show("Delete " + deletedUser.LastName + "?", "Deleting",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                UsersBindList.Remove(deletedUser);
                UsersBusinessLogic.DeleteUser(deletedUser);
            }
        }

        private void AddPrizeToUser()
        {
            User user = (User)dataGridViewUsers.SelectedCells[0].OwningRow.DataBoundItem;
            FormRewardingUser formRewardingUser = new FormRewardingUser(this, user);
            formRewardingUser.Show();
        }
        
        private void AddPrize()
        {
            FormAddOrEditPrize formAddPrize = new FormAddOrEditPrize(this);
            formAddPrize.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void EditPrize()
        {
            if (tabContUserPrizeSelection.SelectedIndex != 1)
            {
                throw new Exception("Switch tab");
            }
            Prize editedPrize = (Prize)dataGridViewPrizes.SelectedCells[0].OwningRow.DataBoundItem;
            FormAddOrEditPrize formEditPrize = new FormAddOrEditPrize(this, editedPrize);
            formEditPrize.Show();
        }

        private void tabContListSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabContUserPrizeSelection.SelectedIndex == 1)
            {
                buttonAddUser.Visible = false;
                buttonAddPrizeToUser.Visible = false;
                buttonEditUser.Visible = false;
                buttonDeleteUser.Visible = false;
                buttonEditPrize.Visible = true;
                buttonAddPrize.Visible = true;
                buttonDeletePrize.Visible = true;
            }
            else
            {
                buttonAddUser.Visible = true;
                buttonAddPrizeToUser.Visible = true;
                buttonEditUser.Visible = true;
                buttonDeleteUser.Visible = true;
                buttonEditPrize.Visible = false;
                buttonAddPrize.Visible = false;
                buttonDeletePrize.Visible = false;
            }
        }

        private void buttonAddPrize_Click(object sender, EventArgs e)
        {
            AddPrize();
        }
        
        private void buttonAddPrizeToUser_Click(object sender, EventArgs e)
        {
            AddPrizeToUser();
        }

        private void DeletePrize()
        {
            if (tabContUserPrizeSelection.SelectedIndex != 1)
            {
                throw new Exception("Switch tab");
            }
            Prize deletedPrize = (Prize)dataGridViewPrizes.SelectedCells[0].OwningRow.DataBoundItem;
            DialogResult dialog = MessageBox.Show("Delete " + deletedPrize.Title + "?", "Deleting",
                MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                PrizesBindList.Remove(deletedPrize);
                PrizesBusinessLogic.DeletePrize(deletedPrize, UsersBusinessLogic);
                foreach (User user in UsersBindList)
                {
                    user.PrizesList.Remove(deletedPrize);
                }
            }
        }

        private void dataGridViewUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;
            switch (index)
            {
                case 0:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.ID).ToList());
                    break;
                case 1:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.FirstName).ToList());
                    break;
                case 2:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.LastName).ToList());
                    break;
                case 3:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.BirthDate).ToList());
                    break;
                case 4:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.Age).ToList());
                    break;
                case 5:
                    UsersBindList = new BindingList<User>(UsersBindList.OrderBy(x => x.Prizes).ToList());
                    break;
            }
            dataGridViewUsers.DataSource = UsersBindList;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void buttonDeletePrize_Click(object sender, EventArgs e)
        {
            try
            {
                DeletePrize();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditPrize_Click(object sender, EventArgs e)
        {
            try
            {
                EditPrize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void addPrizeToUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPrizeToUser();
        }

        private void addPrizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPrize();
        }

        private void editPrizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EditPrize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePrizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DeletePrize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
