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
            /*int index = _main.UsersBindList.IndexOf(_rewardUser);
            Prize addingPrize = (Prize)dataGridPrizes.SelectedCells[0].OwningRow.DataBoundItem;
            if (_main.UsersBindList[index].PrizesList.Contains(addingPrize))
            {
                MessageBox.Show("This prize is already added");
            }
            else
            {
                _main.UsersBindList[index].AddPrize(
                addingPrize);
                this.Dispose();
            }*/
            Prize addingPrize = (Prize)dataGridPrizes.SelectedCells[0].OwningRow.DataBoundItem;
            if (_rewardUser.PrizesList.Contains(addingPrize))
            {
                MessageBox.Show("This prize is already added");
            }
            else
            {
                _rewardUser.AddPrize(addingPrize);
                this.Dispose();
            }
        }
    }
}
