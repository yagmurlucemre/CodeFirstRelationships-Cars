namespace ANK17CodeFirstRelationships
{
    partial class CarEngineerForm
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
            label1 = new Label();
            cmbCars = new ComboBox();
            cmbEngineers = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtNumberOfDays = new TextBox();
            dgvCarEngineers = new DataGridView();
            btnAddCarEngineer = new Button();
            btnUpdateCarEngineer = new Button();
            btnDeleteCarEngineer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarEngineers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 0;
            label1.Text = "Car:";
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(76, 33);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(182, 33);
            cmbCars.TabIndex = 1;
            // 
            // cmbEngineers
            // 
            cmbEngineers.FormattingEnabled = true;
            cmbEngineers.Location = new Point(394, 28);
            cmbEngineers.Name = "cmbEngineers";
            cmbEngineers.Size = new Size(182, 33);
            cmbEngineers.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 36);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Engineer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 36);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 4;
            label3.Text = "Number Of Days:";
            // 
            // txtNumberOfDays
            // 
            txtNumberOfDays.Location = new Point(784, 30);
            txtNumberOfDays.Name = "txtNumberOfDays";
            txtNumberOfDays.Size = new Size(184, 31);
            txtNumberOfDays.TabIndex = 5;
            // 
            // dgvCarEngineers
            // 
            dgvCarEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarEngineers.Location = new Point(88, 93);
            dgvCarEngineers.Name = "dgvCarEngineers";
            dgvCarEngineers.RowHeadersWidth = 62;
            dgvCarEngineers.Size = new Size(862, 241);
            dgvCarEngineers.TabIndex = 6;
            // 
            // btnAddCarEngineer
            // 
            btnAddCarEngineer.Location = new Point(88, 380);
            btnAddCarEngineer.Name = "btnAddCarEngineer";
            btnAddCarEngineer.Size = new Size(155, 34);
            btnAddCarEngineer.TabIndex = 7;
            btnAddCarEngineer.Text = "ADD";
            btnAddCarEngineer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCarEngineer
            // 
            btnUpdateCarEngineer.Location = new Point(464, 380);
            btnUpdateCarEngineer.Name = "btnUpdateCarEngineer";
            btnUpdateCarEngineer.Size = new Size(158, 34);
            btnUpdateCarEngineer.TabIndex = 8;
            btnUpdateCarEngineer.Text = "UPDATE";
            btnUpdateCarEngineer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCarEngineer
            // 
            btnDeleteCarEngineer.Location = new Point(784, 380);
            btnDeleteCarEngineer.Name = "btnDeleteCarEngineer";
            btnDeleteCarEngineer.Size = new Size(166, 34);
            btnDeleteCarEngineer.TabIndex = 9;
            btnDeleteCarEngineer.Text = "DELETE";
            btnDeleteCarEngineer.UseVisualStyleBackColor = true;
            // 
            // CarEngineerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(btnDeleteCarEngineer);
            Controls.Add(btnUpdateCarEngineer);
            Controls.Add(btnAddCarEngineer);
            Controls.Add(dgvCarEngineers);
            Controls.Add(txtNumberOfDays);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbEngineers);
            Controls.Add(cmbCars);
            Controls.Add(label1);
            Name = "CarEngineerForm";
            Text = "CarEngineerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCarEngineers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCars;
        private ComboBox cmbEngineers;
        private Label label2;
        private Label label3;
        private TextBox txtNumberOfDays;
        private DataGridView dgvCarEngineers;
        private Button btnAddCarEngineer;
        private Button btnUpdateCarEngineer;
        private Button btnDeleteCarEngineer;
    }
}