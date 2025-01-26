namespace XMLSearch.Views
{
    partial class XMLEdit
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
            txtEdit = new TextBox();
            btnEdit = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            txtNewValue = new TextBox();
            lblNewValue = new Label();
            btnExport = new Button();
            label2 = new Label();
            lblQuant = new Label();
            btnICMS = new Button();
            btnSignature = new Button();
            SuspendLayout();
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(10, 47);
            txtEdit.Margin = new Padding(3, 2, 3, 2);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(110, 23);
            txtEdit.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(24, 89);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 14);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite o nome da chave para alterar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alterar Valor", "Apagar tag" });
            comboBox1.Location = new Point(136, 47);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(149, 91);
            txtNewValue.Margin = new Padding(3, 2, 3, 2);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(110, 23);
            txtNewValue.TabIndex = 4;
            // 
            // lblNewValue
            // 
            lblNewValue.AutoSize = true;
            lblNewValue.Location = new Point(159, 74);
            lblNewValue.Name = "lblNewValue";
            lblNewValue.Size = new Size(68, 15);
            lblNewValue.TabIndex = 5;
            lblNewValue.Text = "Novo valor:";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(186, 208);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(82, 22);
            btnExport.TabIndex = 6;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 215);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 7;
            label2.Text = "Quant. XMLs:";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(95, 215);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(38, 15);
            lblQuant.TabIndex = 8;
            lblQuant.Text = "label3";
            // 
            // btnICMS
            // 
            btnICMS.Location = new Point(24, 129);
            btnICMS.Margin = new Padding(3, 2, 3, 2);
            btnICMS.Name = "btnICMS";
            btnICMS.Size = new Size(149, 22);
            btnICMS.TabIndex = 9;
            btnICMS.Text = "Corrigir ICMS Deson";
            btnICMS.UseVisualStyleBackColor = true;
            btnICMS.Click += btnICMS_Click;
            // 
            // btnSignature
            // 
            btnSignature.Location = new Point(33, 169);
            btnSignature.Margin = new Padding(3, 2, 3, 2);
            btnSignature.Name = "btnSignature";
            btnSignature.Size = new Size(82, 22);
            btnSignature.TabIndex = 10;
            btnSignature.Text = "Assinar XMLs";
            btnSignature.UseVisualStyleBackColor = true;
            btnSignature.Click += btnSignature_Click;
            // 
            // XMLEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 241);
            Controls.Add(btnSignature);
            Controls.Add(btnICMS);
            Controls.Add(lblQuant);
            Controls.Add(label2);
            Controls.Add(btnExport);
            Controls.Add(lblNewValue);
            Controls.Add(txtNewValue);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(txtEdit);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "XMLEdit";
            Text = "XMLEdit";
            Load += XMLEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdit;
        private Button btnEdit;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox txtNewValue;
        private Label lblNewValue;
        private Button btnExport;
        private Label label2;
        private Label lblQuant;
        private Button btnICMS;
        private Button btnSignature;
    }
}