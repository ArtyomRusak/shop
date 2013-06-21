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
    public partial class MainWindow : Form
    {
        private string _id;
        private string _model;
        private parametersTableAdapter _parametersT = new parametersTableAdapter();
        private modelsTableAdapter _modelT = new modelsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bAddModel_Click(object sender, EventArgs e)
        {
            if (dataGridForCompanies.CurrentRow != null)
            {
                string company = dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString();
                var companies = from p in dsMain.companies where p.Company == company select p;
                foreach (var row in companies)
                {
                    _id = row.ID;
                }
                AddModelForm form = new AddModelForm(company, _id);
                form.ShowDialog();
                relationsForModelTableAdapter.Fill(dsMain.relationsForModel, _id);
            }
            else
            {
                MessageBox.Show("Пустая таблица!");
            }
        }

        private void bAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm form = new AddCompanyForm();
            form.ShowDialog();
            companiesTableAdapter.Fill(dsMain.companies);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            companiesTableAdapter.Fill(dsMain.companies);
            if (dataGridForCompanies.CurrentRow != null)
            {
                foreach (var row in Enumerable.Where(dsMain.companies, row => row.Company == dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString()))
                {
                    _id = row.ID;
                }
                relationsForModelTableAdapter.Fill(dsMain.relationsForModel, _id);
                if (dataGridForModels.CurrentRow != null)
                {
                    _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
                    relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void bAddParameter_Click(object sender, EventArgs e)
        {
            if (dataGridForModels.CurrentRow != null)
            {
                _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
                string company = dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString();
                AddParametersForm form = new AddParametersForm(company, _model);
                form.ShowDialog();
                relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
            }
            else
            {
                MessageBox.Show("Пустая таблица!");
            }
        }

        private void dataGridForCompanies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            foreach (var row in Enumerable.Where(dsMain.companies, row => row.Company == dataGridForCompanies[0, e.RowIndex].Value.ToString()))
            {
                _id = row.ID;
            }
            relationsForModelTableAdapter.Fill(dsMain.relationsForModel, _id);
            if (dataGridForModels.CurrentRow != null)
            {
                _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
                relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
            }
            else
            {
                relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, "");
            }
        }

        private void dataGridForModels_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
            relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
        }

        private void bDeleteParameter_Click(object sender, EventArgs e)
        {
            _parametersT.Fill(dsMain.parameters);
            if (dataGridForParameters.CurrentRow != null)
            {
                var confirmMessage = MessageBox.Show("Вы уверены, что хотите удалить параметр?", "Удаление", MessageBoxButtons.OKCancel);
                if (confirmMessage.ToString() == "OK")
                {
                    int number = 0;
                    string color = dataGridForParameters[1, dataGridForParameters.CurrentRow.Index].Value.ToString();
                    foreach (var row in dsMain.parameters.Where(z => z.Color == color && z.Model_ID == _model))
                    {
                        number = row.Number;
                    }
                    _parametersT.Delete(number);
                    relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пустая таблица!");
            }
        }

        private void bDeleteModel_Click(object sender, EventArgs e)
        {
            _parametersT.Fill(dsMain.parameters);
            _modelT.Fill(dsMain.models);
            if (dataGridForModels.CurrentRow != null)
            {
                var confirmMessage = MessageBox.Show("Вы уверены, что хотите удалить модель и все её параметры?", "Удаление", MessageBoxButtons.OKCancel);
                if (confirmMessage.ToString() == "OK")
                {
                    foreach (var row in dsMain.parameters.Where(z => z.Model_ID == _model))
                    {
                        _parametersT.Delete(row.Number);
                    }
                    _modelT.Delete(_model);
                    relationsForModelTableAdapter.Fill(dsMain.relationsForModel, _id);
                    if (dataGridForModels.CurrentRow != null)
                    {
                        _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
                        relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
                    }
                    else
                    {
                        relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, "");
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пустая таблица!");
            }
        }

        private void bDeleteCompany_Click(object sender, EventArgs e)
        {
            _parametersT.Fill(dsMain.parameters);
            _modelT.Fill(dsMain.models);
            if (dataGridForCompanies.CurrentRow != null)
            {
                var confirmMessage = MessageBox.Show("Вы уверены, что хотите удалить компанию, все её модели и все её параметры?", "Удаление", MessageBoxButtons.OKCancel);
                if (confirmMessage.ToString() == "OK")
                {
                    foreach (var rowCompany in dsMain.companies.Where(row => row.Company == dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString()))
                    {
                        _id = rowCompany.ID;
                        foreach (var rowModel in dsMain.models.Where(row => row.Company_ID == _id))
                        {
                            _model = rowModel.Model;
                            foreach (var rowParameter in dsMain.parameters.Where(row => row.Model_ID == _model))
                            {
                                _parametersT.Delete(rowParameter.Number);
                            }
                            _modelT.Delete(_model);
                        }
                        companiesTableAdapter.Delete(
                            dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString(), _id);
                    }
                    companiesTableAdapter.Fill(dsMain.companies);

                    if (dataGridForCompanies.CurrentRow != null)
                    {
                        foreach (var row in Enumerable.Where(dsMain.companies, row => row.Company == dataGridForCompanies[0, dataGridForCompanies.CurrentRow.Index].Value.ToString()))
                        {
                            _id = row.ID;
                        }
                        relationsForModelTableAdapter.Fill(dsMain.relationsForModel, _id);
                        if (dataGridForModels.CurrentRow != null)
                        {
                            _model = dataGridForModels[0, dataGridForModels.CurrentRow.Index].Value.ToString();
                            relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, _model);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        relationsForModelTableAdapter.Fill(dsMain.relationsForModel, "");
                        relationsForParameterTableAdapter.Fill(dsMain.relationsForParameter, "");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Пустая таблица!");
            }
        }

        private void dataGridForParameters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _parametersT.Fill(dsMain.parameters);
            string columnName = dataGridForParameters.Columns[e.ColumnIndex].HeaderText;
            string color = dataGridForParameters[1, dataGridForParameters.CurrentRow.Index].Value.ToString();
            foreach (var row in dsMain.parameters.Where(z => z.Color == color && z.Model_ID == _model))
            {
                row[columnName] = dataGridForParameters[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            try
            {
                _parametersT.Update(dsMain.parameters);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные параметры!");
            }
        }

        private void dataGridForParameters_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверные данные! Попробуйте ещё раз!");
        }
    }
}