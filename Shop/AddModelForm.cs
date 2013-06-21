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
    public partial class AddModelForm : Form
    {
        private string _company = "";
        private string _id = "";
        private Shop.dsMainTableAdapters.modelsTableAdapter modelT = new modelsTableAdapter();

        public AddModelForm()
        {
            InitializeComponent();
        }

        public AddModelForm(string company, string id)
        {
            _company = company;
            _id = id;
            InitializeComponent();
            label1.Text = String.Format("Модели для фирмы {0}", _company);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tModel.Text == "" || tModel.Text.Count() > 9)
            {
                MessageBox.Show("Пустое поле или превышение знаков!");
            }
            else
            {
                try
                {
                    modelT.Insert(tModel.Text, _id);
                    AddModelForm_FormClosed(null, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Нарушение уникальности!");
                    return;
                }
            }
        }

        private void AddModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void AddModelForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bAdd.PerformClick();
            }
        }
    }
}
