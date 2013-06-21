namespace Shop
{
    partial class MainWindow
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
            this.dataGridForCompanies = new System.Windows.Forms.DataGridView();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new Shop.dsMain();
            this.dataGridForModels = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationsForModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridForParameters = new System.Windows.Forms.DataGridView();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationsForParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAddCompany = new System.Windows.Forms.Button();
            this.bAddModel = new System.Windows.Forms.Button();
            this.bAddParameter = new System.Windows.Forms.Button();
            this.bDeleteCompany = new System.Windows.Forms.Button();
            this.bDeleteModel = new System.Windows.Forms.Button();
            this.bDeleteParameter = new System.Windows.Forms.Button();
            this.companiesTableAdapter = new Shop.dsMainTableAdapters.companiesTableAdapter();
            this.relationsForParameterTableAdapter = new Shop.dsMainTableAdapters.relationsForParameterTableAdapter();
            this.relationsForModelTableAdapter = new Shop.dsMainTableAdapters.relationsForModelTableAdapter();
            this.lAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsForModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsForParameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridForCompanies
            // 
            this.dataGridForCompanies.AllowUserToAddRows = false;
            this.dataGridForCompanies.AllowUserToDeleteRows = false;
            this.dataGridForCompanies.AllowUserToResizeColumns = false;
            this.dataGridForCompanies.AutoGenerateColumns = false;
            this.dataGridForCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridForCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridForCompanies.DataSource = this.companiesBindingSource;
            this.dataGridForCompanies.Location = new System.Drawing.Point(30, 35);
            this.dataGridForCompanies.MultiSelect = false;
            this.dataGridForCompanies.Name = "dataGridForCompanies";
            this.dataGridForCompanies.ReadOnly = true;
            this.dataGridForCompanies.Size = new System.Drawing.Size(194, 506);
            this.dataGridForCompanies.TabIndex = 0;
            this.dataGridForCompanies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridForCompanies_CellMouseClick);
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 70;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "dsMain";
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridForModels
            // 
            this.dataGridForModels.AllowUserToAddRows = false;
            this.dataGridForModels.AllowUserToDeleteRows = false;
            this.dataGridForModels.AllowUserToResizeColumns = false;
            this.dataGridForModels.AutoGenerateColumns = false;
            this.dataGridForModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridForModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn});
            this.dataGridForModels.DataSource = this.relationsForModelBindingSource;
            this.dataGridForModels.Location = new System.Drawing.Point(279, 35);
            this.dataGridForModels.MultiSelect = false;
            this.dataGridForModels.Name = "dataGridForModels";
            this.dataGridForModels.ReadOnly = true;
            this.dataGridForModels.Size = new System.Drawing.Size(147, 506);
            this.dataGridForModels.TabIndex = 1;
            this.dataGridForModels.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridForModels_CellMouseClick);
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationsForModelBindingSource
            // 
            this.relationsForModelBindingSource.DataMember = "relationsForModel";
            this.relationsForModelBindingSource.DataSource = this.dsMain;
            // 
            // dataGridForParameters
            // 
            this.dataGridForParameters.AllowUserToAddRows = false;
            this.dataGridForParameters.AllowUserToDeleteRows = false;
            this.dataGridForParameters.AllowUserToResizeColumns = false;
            this.dataGridForParameters.AutoGenerateColumns = false;
            this.dataGridForParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridForParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelIDDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridForParameters.DataSource = this.relationsForParameterBindingSource;
            this.dataGridForParameters.Location = new System.Drawing.Point(470, 35);
            this.dataGridForParameters.MultiSelect = false;
            this.dataGridForParameters.Name = "dataGridForParameters";
            this.dataGridForParameters.Size = new System.Drawing.Size(485, 506);
            this.dataGridForParameters.TabIndex = 2;
            this.dataGridForParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridForParameters_CellEndEdit);
            this.dataGridForParameters.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridForParameters_DataError);
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            this.modelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "35";
            this.dataGridViewTextBoxColumn1.HeaderText = "35";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "36";
            this.dataGridViewTextBoxColumn2.HeaderText = "36";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "37";
            this.dataGridViewTextBoxColumn3.HeaderText = "37";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "38";
            this.dataGridViewTextBoxColumn4.HeaderText = "38";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "39";
            this.dataGridViewTextBoxColumn5.HeaderText = "39";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "40";
            this.dataGridViewTextBoxColumn6.HeaderText = "40";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "41";
            this.dataGridViewTextBoxColumn7.HeaderText = "41";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "42";
            this.dataGridViewTextBoxColumn8.HeaderText = "42";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "43";
            this.dataGridViewTextBoxColumn9.HeaderText = "43";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 30;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "44";
            this.dataGridViewTextBoxColumn10.HeaderText = "44";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 30;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "45";
            this.dataGridViewTextBoxColumn11.HeaderText = "45";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 30;
            // 
            // relationsForParameterBindingSource
            // 
            this.relationsForParameterBindingSource.DataMember = "relationsForParameter";
            this.relationsForParameterBindingSource.DataSource = this.dsMain;
            // 
            // bAddCompany
            // 
            this.bAddCompany.Location = new System.Drawing.Point(57, 6);
            this.bAddCompany.Name = "bAddCompany";
            this.bAddCompany.Size = new System.Drawing.Size(131, 23);
            this.bAddCompany.TabIndex = 3;
            this.bAddCompany.Text = "Добавить компанию";
            this.bAddCompany.UseVisualStyleBackColor = true;
            this.bAddCompany.Click += new System.EventHandler(this.bAddCompany_Click);
            // 
            // bAddModel
            // 
            this.bAddModel.Location = new System.Drawing.Point(299, 6);
            this.bAddModel.Name = "bAddModel";
            this.bAddModel.Size = new System.Drawing.Size(109, 23);
            this.bAddModel.TabIndex = 4;
            this.bAddModel.Text = "Добавить модель";
            this.bAddModel.UseVisualStyleBackColor = true;
            this.bAddModel.Click += new System.EventHandler(this.bAddModel_Click);
            // 
            // bAddParameter
            // 
            this.bAddParameter.Location = new System.Drawing.Point(637, 6);
            this.bAddParameter.Name = "bAddParameter";
            this.bAddParameter.Size = new System.Drawing.Size(170, 23);
            this.bAddParameter.TabIndex = 5;
            this.bAddParameter.Text = "Добавить параметры";
            this.bAddParameter.UseVisualStyleBackColor = true;
            this.bAddParameter.Click += new System.EventHandler(this.bAddParameter_Click);
            // 
            // bDeleteCompany
            // 
            this.bDeleteCompany.Location = new System.Drawing.Point(21, 547);
            this.bDeleteCompany.Name = "bDeleteCompany";
            this.bDeleteCompany.Size = new System.Drawing.Size(212, 23);
            this.bDeleteCompany.TabIndex = 6;
            this.bDeleteCompany.Text = "Удалить компанию и её модели";
            this.bDeleteCompany.UseVisualStyleBackColor = true;
            this.bDeleteCompany.Click += new System.EventHandler(this.bDeleteCompany_Click);
            // 
            // bDeleteModel
            // 
            this.bDeleteModel.Location = new System.Drawing.Point(258, 547);
            this.bDeleteModel.Name = "bDeleteModel";
            this.bDeleteModel.Size = new System.Drawing.Size(196, 23);
            this.bDeleteModel.TabIndex = 7;
            this.bDeleteModel.Text = "Удалить модель и её параметры";
            this.bDeleteModel.UseVisualStyleBackColor = true;
            this.bDeleteModel.Click += new System.EventHandler(this.bDeleteModel_Click);
            // 
            // bDeleteParameter
            // 
            this.bDeleteParameter.Location = new System.Drawing.Point(637, 547);
            this.bDeleteParameter.Name = "bDeleteParameter";
            this.bDeleteParameter.Size = new System.Drawing.Size(170, 23);
            this.bDeleteParameter.TabIndex = 8;
            this.bDeleteParameter.Text = "Удалить параметры";
            this.bDeleteParameter.UseVisualStyleBackColor = true;
            this.bDeleteParameter.Click += new System.EventHandler(this.bDeleteParameter_Click);
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // relationsForParameterTableAdapter
            // 
            this.relationsForParameterTableAdapter.ClearBeforeFill = true;
            // 
            // relationsForModelTableAdapter
            // 
            this.relationsForModelTableAdapter.ClearBeforeFill = true;
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAuthor.Location = new System.Drawing.Point(767, 573);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(188, 20);
            this.lAuthor.TabIndex = 9;
            this.lAuthor.Text = "Made by Artyom Rusak ©";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 600);
            this.Controls.Add(this.lAuthor);
            this.Controls.Add(this.bDeleteParameter);
            this.Controls.Add(this.bDeleteModel);
            this.Controls.Add(this.bDeleteCompany);
            this.Controls.Add(this.bAddParameter);
            this.Controls.Add(this.bAddModel);
            this.Controls.Add(this.bAddCompany);
            this.Controls.Add(this.dataGridForParameters);
            this.Controls.Add(this.dataGridForModels);
            this.Controls.Add(this.dataGridForCompanies);
            this.Name = "MainWindow";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsForModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridForParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsForParameterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridForCompanies;
        private System.Windows.Forms.DataGridView dataGridForModels;
        private System.Windows.Forms.DataGridView dataGridForParameters;
        private System.Windows.Forms.Button bAddCompany;
        private System.Windows.Forms.Button bAddModel;
        private System.Windows.Forms.Button bAddParameter;
        private System.Windows.Forms.Button bDeleteCompany;
        private System.Windows.Forms.Button bDeleteModel;
        private System.Windows.Forms.Button bDeleteParameter;
        private dsMain dsMain;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private dsMainTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource relationsForModelBindingSource;
        private System.Windows.Forms.BindingSource relationsForParameterBindingSource;
        private dsMainTableAdapters.relationsForParameterTableAdapter relationsForParameterTableAdapter;
        private dsMainTableAdapters.relationsForModelTableAdapter relationsForModelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label lAuthor;
    }
}

