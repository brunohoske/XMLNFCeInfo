namespace XMLSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileDialog = new OpenFileDialog();
            btnSelectFiles = new Button();
            panel1 = new Panel();
            txtSaltos = new TextBox();
            lblQuantSaltos = new Label();
            label2 = new Label();
            label1 = new Label();
            lblQuantXml = new Label();
            label3 = new Label();
            gridView = new DataGridView();
            btnXmlEdit = new Button();
            chkSelectAll = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // fileDialog
            // 
            fileDialog.FileName = "openFileDialog1";
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Location = new Point(2, 16);
            btnSelectFiles.Margin = new Padding(3, 2, 3, 2);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(82, 22);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = true;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSaltos);
            panel1.Controls.Add(lblQuantSaltos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(525, 41);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 256);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txtSaltos
            // 
            txtSaltos.Location = new Point(39, 71);
            txtSaltos.Margin = new Padding(3, 2, 3, 2);
            txtSaltos.Multiline = true;
            txtSaltos.Name = "txtSaltos";
            txtSaltos.Size = new Size(110, 74);
            txtSaltos.TabIndex = 8;
            // 
            // lblQuantSaltos
            // 
            lblQuantSaltos.AutoSize = true;
            lblQuantSaltos.Location = new Point(105, 14);
            lblQuantSaltos.Name = "lblQuantSaltos";
            lblQuantSaltos.Size = new Size(38, 15);
            lblQuantSaltos.TabIndex = 5;
            lblQuantSaltos.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Saltos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Quant. Saltos:";
            // 
            // lblQuantXml
            // 
            lblQuantXml.AutoSize = true;
            lblQuantXml.Location = new Point(446, 20);
            lblQuantXml.Name = "lblQuantXml";
            lblQuantXml.Size = new Size(13, 15);
            lblQuantXml.TabIndex = 6;
            lblQuantXml.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 20);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Quant. XML:";
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(89, 41);
            gridView.Margin = new Padding(3, 2, 3, 2);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridView.Size = new Size(408, 256);
            gridView.TabIndex = 3;
            gridView.CellContentClick += gridView_CellContentClick;
            // 
            // btnXmlEdit
            // 
            btnXmlEdit.Location = new Point(2, 89);
            btnXmlEdit.Margin = new Padding(3, 2, 3, 2);
            btnXmlEdit.Name = "btnXmlEdit";
            btnXmlEdit.Size = new Size(82, 22);
            btnXmlEdit.TabIndex = 4;
            btnXmlEdit.Text = "Editar XML";
            btnXmlEdit.UseVisualStyleBackColor = true;
            btnXmlEdit.Click += btnXmlEdit_Click;
            // 
            // chkSelectAll
            // 
            chkSelectAll.AutoSize = true;
            chkSelectAll.Location = new Point(98, 19);
            chkSelectAll.Margin = new Padding(3, 2, 3, 2);
            chkSelectAll.Name = "chkSelectAll";
            chkSelectAll.Size = new Size(113, 19);
            chkSelectAll.TabIndex = 5;
            chkSelectAll.Text = "Selecionar todos";
            chkSelectAll.UseVisualStyleBackColor = true;
            chkSelectAll.CheckedChanged += chkSelectAll_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F);
            label6.Location = new Point(715, 322);
            label6.Name = "label6";
            label6.Size = new Size(52, 11);
            label6.TabIndex = 6;
            label6.Text = "Bruno Hoske";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 24);
            label7.Name = "label7";
            label7.Size = new Size(149, 15);
            label7.TabIndex = 7;
            label7.Text = "Painel de Saltos (Em breve)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 338);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblQuantXml);
            Controls.Add(chkSelectAll);
            Controls.Add(btnXmlEdit);
            Controls.Add(gridView);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnSelectFiles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog fileDialog;
        private Button btnSelectFiles;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblQuantXml;
        private Label lblQuantSaltos;
        private TextBox txtSaltos;
        private DataGridView gridView;
        private Button btnXmlEdit;
        private CheckBox chkSelectAll;
        private Label label6;
        private Label label7;
    }
}
