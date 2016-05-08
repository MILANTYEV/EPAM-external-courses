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
    public partial class FormAddOrEditPrize : Form
    {
        private const int MAX_DESCRIPTION_LENGTH = 250;
        private const int MAX_TITLE_LENGTH = 50;
        FormMain _mainForm;
        Prize _editedPrize;

        public FormAddOrEditPrize(FormMain mainForm)
        {
            this._mainForm = mainForm;
            InitializeComponent();
            buttonAdd.Visible = true;
            buttonAcceptChanges.Visible = false;
        }

        public FormAddOrEditPrize(FormMain mainForm, Prize editedPrize)
        {
            this._mainForm = mainForm;
            this._editedPrize = editedPrize;
            InitializeComponent();
            this.Text = "Edit prize";
            textBoxTitle.Text = _editedPrize.Title;
            richTextBoxDescription.Text = _editedPrize.Description;
            buttonAcceptChanges.Visible = true;
            buttonAdd.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Prize prize = _mainForm.PrizesBusinessLogic.CreatePrize(CutString(textBoxTitle.Text, MAX_TITLE_LENGTH),
                    CutString(richTextBoxDescription.Text, MAX_DESCRIPTION_LENGTH));
                _mainForm.PrizesBindList.Add(prize);
                _mainForm.PrizesBusinessLogic.AddPrize(prize);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CutString(string text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                char[] destinationArr = new char[maxLength];
                text.CopyTo(0, destinationArr, 0, maxLength);
                text = new String(destinationArr);
                MessageBox.Show("Line has been reduced");
            }
            return text;
        }

        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {
            try
            {
                int index = _mainForm.PrizesBindList.IndexOf(_editedPrize);
                Prize oldPrize = _editedPrize;
                _mainForm.PrizesBindList[index].Title = textBoxTitle.Text;
                _mainForm.PrizesBindList[index].Description = richTextBoxDescription.Text;
                Prize newPrize = _mainForm.PrizesBindList[index];
                _mainForm.PrizesBusinessLogic.ChangePrize(oldPrize, newPrize);
                MessageBox.Show("Changes accepted");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
