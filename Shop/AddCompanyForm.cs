using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.dsMainTableAdapters;

namespace Shop
{
    public partial class AddCompanyForm : Form
    {
        private TextBox[] _controls;
        private Shop.dsMainTableAdapters.companiesTableAdapter _companiesT = new companiesTableAdapter();

        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            _controls = this.Controls.OfType<TextBox>().ToArray();
            if (_controls.Any(z => z.Text == ""))
            {
                MessageBox.Show("Введите все поля!");
                return;
            }
            else
            {
                if (tName.Text.Count() > 49 || tID.Text.Count() > 9)
                {
                    MessageBox.Show("Недопустимая длина!");
                    return;
                }
            }
            try
            {
                _companiesT.Insert(tName.Text, tID.Text);
                this.AddCompanyForm_FormClosed(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления! Нарушение уникальности!");
                return;
            }
        }

        private void AddCompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void AddCompanyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bAdd.PerformClick();
            }
        }
    }
}
