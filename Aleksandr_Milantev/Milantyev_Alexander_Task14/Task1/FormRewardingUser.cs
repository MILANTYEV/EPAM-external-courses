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
    public partial class FormRewardingUser : Form
    {
        private FormMain _main;
        private User _rewardUser;
        
        public FormRewardingUser(FormMain formMain, User user)
        {
            this._main = formMain;
            this._rewardUser = user;
            InitializeComponent();
            labelUser.Text += user.FirstName + " " + user.LastName;
            dataGridPrizes.DataSource = _main.PrizesBindList;
        }

        private void buttonAddPrizeToUser_Click(object sender, EventArgs e)
        {
            Prize addingPrize = (Prize)dataGridPrizes.SelectedCells[0].OwningRow.DataBoundItem;
            if (_rewardUser.PrizesList.Contains(addingPrize))
            {
                MessageBox.Show("This prize is already added");
            }
            else
            {
                User oldUser = _rewardUser;
                _rewardUser.AddPrize(addingPrize);
                User newUser = _rewardUser;
                if (! _main.UsersBusinessLogic.GetUsersList().ToList().Contains(oldUser))
                {
                    _main.UsersBusinessLogic.AddUser(oldUser);
                }
                _main.UsersBusinessLogic.ChangeUser(oldUser, newUser);
                this.Dispose();
            }
        }
    }
}
