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
    public partial class AddParametersForm : Form
    {
        private string _company = "";
        private string _model = "";
        private string _id = "";
        private TextBox[] controls;
        private dsMain _dsM = new dsMain();
        private bool _isRight = false;
        private parametersTableAdapter _parametersT = new parametersTableAdapter();

        public AddParametersForm()
        {
            InitializeComponent();
        }

        public AddParametersForm(string company, string model)
        {
            _company = company;
            _model = model;
            InitializeComponent();
            lCompany.Text = _company;
            lModel.Text = _model;
            controls = this.Controls.OfType<TextBox>().ToArray();
            foreach (var textBox in controls)
            {
                textBox.Text = "0";
            }
            tColor.Text = "";
            _parametersT.Fill(_dsM.parameters);
        }

        private void tColor_TextChanged(object sender, EventArgs e)
        {
            _isRight = true;
            if (_dsM.parameters.Any(z => z.Color == tColor.Text && z.Model_ID == _model))
            {
                MessageBox.Show("Такой цвет уже имеется");
                _isRight = false;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (controls.Any(z => z.Text == ""))
            {
                MessageBox.Show("Пустые поля!");
                return;
            }
            if (_isRight == false)
            {
                MessageBox.Show("Такой цвет уже имеется или вы не ввели его!");
                return;
            }
            try
            {
                _parametersT.Insert(_model, tColor.Text, int.Parse(textBox1.Text), int.Parse(textBox2.Text),
                                    int.Parse(textBox3.Text),
                                    int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text),
                                    int.Parse(textBox7.Text),
                                    int.Parse(textBox8.Text), int.Parse(textBox9.Text), int.Parse(textBox10.Text),
                                    int.Parse(textBox11.Text));
                AddParametersForm_FormClosed(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные!");
                return;
            }
        }

        private void AddParametersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void AddParametersForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bAdd.PerformClick();
            }
        }
    }
}