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
            txtEdit.Location = new Point(12, 63);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(125, 27);
            txtEdit.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(28, 119);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite o nome da chave para alterar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alterar Valor", "Apagar tag" });
            comboBox1.Location = new Point(155, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(170, 121);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(125, 27);
            txtNewValue.TabIndex = 4;
            // 
            // lblNewValue
            // 
            lblNewValue.AutoSize = true;
            lblNewValue.Location = new Point(182, 98);
            lblNewValue.Name = "lblNewValue";
            lblNewValue.Size = new Size(85, 20);
            lblNewValue.TabIndex = 5;
            lblNewValue.Text = "Novo valor:";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(212, 278);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 6;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 287);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 7;
            label2.Text = "Quant. XMLs:";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(109, 287);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(50, 20);
            lblQuant.TabIndex = 8;
            lblQuant.Text = "label3";
            // 
            // btnICMS
            // 
            btnICMS.Location = new Point(28, 172);
            btnICMS.Name = "btnICMS";
            btnICMS.Size = new Size(170, 29);
            btnICMS.TabIndex = 9;
            btnICMS.Text = "Corrigir ICMS Deson";
            btnICMS.UseVisualStyleBackColor = true;
            btnICMS.Click += btnICMS_Click;
            // 
            // btnSignature
            // 
            btnSignature.Location = new Point(38, 225);
            btnSignature.Name = "btnSignature";
            btnSignature.Size = new Size(94, 29);
            btnSignature.TabIndex = 10;
            btnSignature.Text = "Assinar XMLs";
            btnSignature.UseVisualStyleBackColor = true;
            btnSignature.Click += btnSignature_Click;
            // 
            // XMLEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 321);
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