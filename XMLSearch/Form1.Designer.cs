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
            label5 = new Label();
            lblQuantXml = new Label();
            lblQuantSaltos = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gridView = new DataGridView();
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
            btnSelectFiles.Location = new Point(12, 22);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(94, 29);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Select Files";
            btnSelectFiles.UseVisualStyleBackColor = true;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSaltos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblQuantXml);
            panel1.Controls.Add(lblQuantSaltos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(516, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 341);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // txtSaltos
            // 
            txtSaltos.Location = new Point(45, 95);
            txtSaltos.Multiline = true;
            txtSaltos.Name = "txtSaltos";
            txtSaltos.Size = new Size(125, 98);
            txtSaltos.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 253);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // lblQuantXml
            // 
            lblQuantXml.AutoSize = true;
            lblQuantXml.Location = new Point(118, 216);
            lblQuantXml.Name = "lblQuantXml";
            lblQuantXml.Size = new Size(50, 20);
            lblQuantXml.TabIndex = 6;
            lblQuantXml.Text = "label5";
            // 
            // lblQuantSaltos
            // 
            lblQuantSaltos.AutoSize = true;
            lblQuantSaltos.Location = new Point(120, 18);
            lblQuantSaltos.Name = "lblQuantSaltos";
            lblQuantSaltos.Size = new Size(50, 20);
            lblQuantSaltos.TabIndex = 5;
            lblQuantSaltos.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 253);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 216);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Quant. XML:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Saltos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Quant. Saltos:";
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(102, 55);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridView.Size = new Size(387, 341);
            gridView.TabIndex = 3;
            gridView.CellContentClick += gridView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridView);
            Controls.Add(panel1);
            Controls.Add(btnSelectFiles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog fileDialog;
        private Button btnSelectFiles;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lblQuantXml;
        private Label lblQuantSaltos;
        private TextBox txtSaltos;
        private DataGridView gridView;
    }
}
