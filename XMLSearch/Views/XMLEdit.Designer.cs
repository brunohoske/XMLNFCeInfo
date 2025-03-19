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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(24, 43);
            txtEdit.Margin = new Padding(3, 2, 3, 2);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(110, 23);
            txtEdit.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 133);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Aplicar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Chave p/ editar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alterar Valor", "Apagar tag" });
            comboBox1.Location = new Point(178, 43);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(178, 94);
            txtNewValue.Margin = new Padding(3, 2, 3, 2);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(110, 23);
            txtNewValue.TabIndex = 4;
            // 
            // lblNewValue
            // 
            lblNewValue.AutoSize = true;
            lblNewValue.Location = new Point(178, 77);
            lblNewValue.Name = "lblNewValue";
            lblNewValue.Size = new Size(68, 15);
            lblNewValue.TabIndex = 5;
            lblNewValue.Text = "Novo valor:";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(244, 283);
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
            label2.Location = new Point(12, 292);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 7;
            label2.Text = "Quant. XMLs:";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(97, 292);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(38, 15);
            lblQuant.TabIndex = 8;
            lblQuant.Text = "label3";
            // 
            // btnICMS
            // 
            btnICMS.Location = new Point(12, 234);
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
            btnSignature.Location = new Point(244, 255);
            btnSignature.Margin = new Padding(3, 2, 3, 2);
            btnSignature.Name = "btnSignature";
            btnSignature.Size = new Size(82, 22);
            btnSignature.TabIndex = 10;
            btnSignature.Text = "Assinar XMLs";
            btnSignature.UseVisualStyleBackColor = true;
            btnSignature.Click += btnSignature_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 26);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 11;
            label3.Text = "Selecione a ação a realizar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Extra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.Location = new Point(36, 157);
            label5.Name = "label5";
            label5.Size = new Size(180, 12);
            label5.TabIndex = 13;
            label5.Text = "Após aplicar, exporte os XML's alterados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(7, 68);
            label6.Name = "label6";
            label6.Size = new Size(83, 12);
            label6.TabIndex = 14;
            label6.Text = "Não utilize \"</>\" ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F);
            label7.Location = new Point(29, 80);
            label7.Name = "label7";
            label7.Size = new Size(132, 12);
            label7.TabIndex = 15;
            label7.Text = "digite apenas o nome da tag";
            label7.Click += label7_Click;
            // 
            // XMLEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 316);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Text = "Editar";
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}