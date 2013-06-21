namespace Shop
{
    partial class AddCompanyForm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.tName = new System.Windows.Forms.TextBox();
            this.tID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(100, 76);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(104, 31);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(24, 30);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(112, 20);
            this.tName.TabIndex = 1;
            // 
            // tID
            // 
            this.tID.Location = new System.Drawing.Point(169, 30);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(112, 20);
            this.tID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя компании";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Идентификатор";
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 123);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.bAdd);
            this.KeyPreview = true;
            this.Name = "AddCompanyForm";
            this.Text = "Добавление компании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCompanyForm_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCompanyForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}