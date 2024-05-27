namespace ANK17CodeFirstRelationships
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
            grpLicensePlates = new GroupBox();
            lblSelectedPlate = new Label();
            dgvPlates = new DataGridView();
            btnDeletePlate = new Button();
            btnUpdatePlate = new Button();
            btnAddPlate = new Button();
            txtPlateNumber = new TextBox();
            label1 = new Label();
            grpPeople = new GroupBox();
            txtName = new TextBox();
            label2 = new Label();
            lblSelectedPerson = new Label();
            dgvPeople = new DataGridView();
            btnDeletePerson = new Button();
            btnUpdatePerson = new Button();
            btnAddPerson = new Button();
            txtSurname = new TextBox();
            label3 = new Label();
            grpCar = new GroupBox();
            label6 = new Label();
            cmbLicensePlates = new ComboBox();
            cmbOwners = new ComboBox();
            label5 = new Label();
            txtBrand = new TextBox();
            label4 = new Label();
            lblSelectedCar = new Label();
            dgvCars = new DataGridView();
            btnDeleteCar = new Button();
            btnUpdateCar = new Button();
            btnAddCar = new Button();
            txtColor = new TextBox();
            lblColor = new Label();
            groupBox1 = new GroupBox();
            txtEngineerName = new TextBox();
            label7 = new Label();
            lblSelectedEngineer = new Label();
            dgvEngineers = new DataGridView();
            btnDeleteEngineer = new Button();
            btnUpdateEngineer = new Button();
            btnAddEngineer = new Button();
            txtEngineerSurname = new TextBox();
            label9 = new Label();
            btnCarEngineerForm = new Button();
            grpLicensePlates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlates).BeginInit();
            grpPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            grpCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).BeginInit();
            SuspendLayout();
            // 
            // grpLicensePlates
            // 
            grpLicensePlates.Controls.Add(lblSelectedPlate);
            grpLicensePlates.Controls.Add(dgvPlates);
            grpLicensePlates.Controls.Add(btnDeletePlate);
            grpLicensePlates.Controls.Add(btnUpdatePlate);
            grpLicensePlates.Controls.Add(btnAddPlate);
            grpLicensePlates.Controls.Add(txtPlateNumber);
            grpLicensePlates.Controls.Add(label1);
            grpLicensePlates.Location = new Point(12, 12);
            grpLicensePlates.Name = "grpLicensePlates";
            grpLicensePlates.Size = new Size(413, 586);
            grpLicensePlates.TabIndex = 0;
            grpLicensePlates.TabStop = false;
            grpLicensePlates.Text = "License Plates";
            // 
            // lblSelectedPlate
            // 
            lblSelectedPlate.Location = new Point(6, 27);
            lblSelectedPlate.Name = "lblSelectedPlate";
            lblSelectedPlate.Size = new Size(393, 38);
            lblSelectedPlate.TabIndex = 8;
            lblSelectedPlate.Text = "Selected  Plate :";
            // 
            // dgvPlates
            // 
            dgvPlates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlates.Location = new Point(21, 188);
            dgvPlates.Name = "dgvPlates";
            dgvPlates.RowHeadersWidth = 62;
            dgvPlates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlates.Size = new Size(360, 348);
            dgvPlates.TabIndex = 7;
            dgvPlates.CellClick += dgvPlates_CellClick;
            // 
            // btnDeletePlate
            // 
            btnDeletePlate.Location = new Point(287, 129);
            btnDeletePlate.Name = "btnDeletePlate";
            btnDeletePlate.Size = new Size(112, 34);
            btnDeletePlate.TabIndex = 6;
            btnDeletePlate.Text = "DELETE";
            btnDeletePlate.UseVisualStyleBackColor = true;
            btnDeletePlate.Click += btnDeletePlate_Click;
            // 
            // btnUpdatePlate
            // 
            btnUpdatePlate.Location = new Point(150, 129);
            btnUpdatePlate.Name = "btnUpdatePlate";
            btnUpdatePlate.Size = new Size(112, 34);
            btnUpdatePlate.TabIndex = 5;
            btnUpdatePlate.Text = "UPDATE";
            btnUpdatePlate.UseVisualStyleBackColor = true;
            btnUpdatePlate.Click += btnUpdatePlate_Click;
            // 
            // btnAddPlate
            // 
            btnAddPlate.Location = new Point(6, 129);
            btnAddPlate.Name = "btnAddPlate";
            btnAddPlate.Size = new Size(112, 34);
            btnAddPlate.TabIndex = 2;
            btnAddPlate.Text = "ADD";
            btnAddPlate.UseVisualStyleBackColor = true;
            btnAddPlate.Click += btnAddPlate_Click;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(78, 70);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(321, 31);
            txtPlateNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 73);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "No:";
            // 
            // grpPeople
            // 
            grpPeople.Controls.Add(txtName);
            grpPeople.Controls.Add(label2);
            grpPeople.Controls.Add(lblSelectedPerson);
            grpPeople.Controls.Add(dgvPeople);
            grpPeople.Controls.Add(btnDeletePerson);
            grpPeople.Controls.Add(btnUpdatePerson);
            grpPeople.Controls.Add(btnAddPerson);
            grpPeople.Controls.Add(txtSurname);
            grpPeople.Controls.Add(label3);
            grpPeople.Location = new Point(431, 12);
            grpPeople.Name = "grpPeople";
            grpPeople.Size = new Size(419, 586);
            grpPeople.TabIndex = 1;
            grpPeople.TabStop = false;
            grpPeople.Text = "People";
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 31);
            txtName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // lblSelectedPerson
            // 
            lblSelectedPerson.Location = new Point(6, 27);
            lblSelectedPerson.Name = "lblSelectedPerson";
            lblSelectedPerson.Size = new Size(393, 38);
            lblSelectedPerson.TabIndex = 8;
            lblSelectedPerson.Text = "Selected  Person :";
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(29, 296);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 62;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(360, 240);
            dgvPeople.TabIndex = 7;
            dgvPeople.CellClick += dgvPeople_CellClick;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Location = new Point(292, 225);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(112, 34);
            btnDeletePerson.TabIndex = 6;
            btnDeletePerson.Text = "DELETE";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Location = new Point(155, 225);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(112, 34);
            btnUpdatePerson.TabIndex = 5;
            btnUpdatePerson.Text = "UPDATE";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(11, 225);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(112, 34);
            btnAddPerson.TabIndex = 2;
            btnAddPerson.Text = "ADD";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(116, 160);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(288, 31);
            txtSurname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 163);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 0;
            label3.Text = "Surname:";
            // 
            // grpCar
            // 
            grpCar.Controls.Add(label6);
            grpCar.Controls.Add(cmbLicensePlates);
            grpCar.Controls.Add(cmbOwners);
            grpCar.Controls.Add(label5);
            grpCar.Controls.Add(txtBrand);
            grpCar.Controls.Add(label4);
            grpCar.Controls.Add(lblSelectedCar);
            grpCar.Controls.Add(dgvCars);
            grpCar.Controls.Add(btnDeleteCar);
            grpCar.Controls.Add(btnUpdateCar);
            grpCar.Controls.Add(btnAddCar);
            grpCar.Controls.Add(txtColor);
            grpCar.Controls.Add(lblColor);
            grpCar.Location = new Point(866, 12);
            grpCar.Name = "grpCar";
            grpCar.Size = new Size(419, 586);
            grpCar.TabIndex = 2;
            grpCar.TabStop = false;
            grpCar.Text = "Car";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 268);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 14;
            label6.Text = "Licence Plate:";
            label6.Click += label6_Click;
            // 
            // cmbLicensePlates
            // 
            cmbLicensePlates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicensePlates.FormattingEnabled = true;
            cmbLicensePlates.Location = new Point(132, 260);
            cmbLicensePlates.Name = "cmbLicensePlates";
            cmbLicensePlates.Size = new Size(272, 33);
            cmbLicensePlates.TabIndex = 13;
            // 
            // cmbOwners
            // 
            cmbOwners.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOwners.FormattingEnabled = true;
            cmbOwners.Location = new Point(132, 202);
            cmbOwners.Name = "cmbOwners";
            cmbOwners.Size = new Size(272, 33);
            cmbOwners.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 210);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 11;
            label5.Text = "Owner:";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(132, 110);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(272, 31);
            txtBrand.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 113);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 9;
            label4.Text = "Brand:";
            label4.Click += label4_Click;
            // 
            // lblSelectedCar
            // 
            lblSelectedCar.Location = new Point(6, 27);
            lblSelectedCar.Name = "lblSelectedCar";
            lblSelectedCar.Size = new Size(393, 38);
            lblSelectedCar.TabIndex = 8;
            lblSelectedCar.Text = "Selected  Car:";
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(29, 396);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersWidth = 62;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(360, 140);
            dgvCars.TabIndex = 7;
            dgvCars.CellClick += dgvCars_CellClick;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(292, 339);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(112, 34);
            btnDeleteCar.TabIndex = 6;
            btnDeleteCar.Text = "DELETE";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // btnUpdateCar
            // 
            btnUpdateCar.Location = new Point(155, 339);
            btnUpdateCar.Name = "btnUpdateCar";
            btnUpdateCar.Size = new Size(112, 34);
            btnUpdateCar.TabIndex = 5;
            btnUpdateCar.Text = "UPDATE";
            btnUpdateCar.UseVisualStyleBackColor = true;
            btnUpdateCar.Click += btnUpdateCar_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(11, 339);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(112, 34);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "ADD";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(132, 160);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(272, 31);
            txtColor.TabIndex = 1;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(11, 163);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(59, 25);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEngineerName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblSelectedEngineer);
            groupBox1.Controls.Add(dgvEngineers);
            groupBox1.Controls.Add(btnDeleteEngineer);
            groupBox1.Controls.Add(btnUpdateEngineer);
            groupBox1.Controls.Add(btnAddEngineer);
            groupBox1.Controls.Add(txtEngineerSurname);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(1291, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 586);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Engineer";
            // 
            // txtEngineerName
            // 
            txtEngineerName.Location = new Point(116, 110);
            txtEngineerName.Name = "txtEngineerName";
            txtEngineerName.Size = new Size(288, 31);
            txtEngineerName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 113);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 9;
            label7.Text = "Name:";
            // 
            // lblSelectedEngineer
            // 
            lblSelectedEngineer.Location = new Point(6, 27);
            lblSelectedEngineer.Name = "lblSelectedEngineer";
            lblSelectedEngineer.Size = new Size(393, 38);
            lblSelectedEngineer.TabIndex = 8;
            lblSelectedEngineer.Text = "Selected  Engineer:";
            // 
            // dgvEngineers
            // 
            dgvEngineers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEngineers.Location = new Point(29, 296);
            dgvEngineers.Name = "dgvEngineers";
            dgvEngineers.RowHeadersWidth = 62;
            dgvEngineers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEngineers.Size = new Size(360, 240);
            dgvEngineers.TabIndex = 7;
            dgvEngineers.CellClick += dgvEngineers_CellClick;
            // 
            // btnDeleteEngineer
            // 
            btnDeleteEngineer.Location = new Point(292, 225);
            btnDeleteEngineer.Name = "btnDeleteEngineer";
            btnDeleteEngineer.Size = new Size(112, 34);
            btnDeleteEngineer.TabIndex = 6;
            btnDeleteEngineer.Text = "DELETE";
            btnDeleteEngineer.UseVisualStyleBackColor = true;
            btnDeleteEngineer.Click += btnDeleteEngineer_Click;
            // 
            // btnUpdateEngineer
            // 
            btnUpdateEngineer.Location = new Point(155, 225);
            btnUpdateEngineer.Name = "btnUpdateEngineer";
            btnUpdateEngineer.Size = new Size(112, 34);
            btnUpdateEngineer.TabIndex = 5;
            btnUpdateEngineer.Text = "UPDATE";
            btnUpdateEngineer.UseVisualStyleBackColor = true;
            btnUpdateEngineer.Click += btnUpdateEngineer_Click;
            // 
            // btnAddEngineer
            // 
            btnAddEngineer.Location = new Point(11, 225);
            btnAddEngineer.Name = "btnAddEngineer";
            btnAddEngineer.Size = new Size(112, 34);
            btnAddEngineer.TabIndex = 2;
            btnAddEngineer.Text = "ADD";
            btnAddEngineer.UseVisualStyleBackColor = true;
            btnAddEngineer.Click += btnAddEngineer_Click;
            // 
            // txtEngineerSurname
            // 
            txtEngineerSurname.Location = new Point(116, 160);
            txtEngineerSurname.Name = "txtEngineerSurname";
            txtEngineerSurname.Size = new Size(288, 31);
            txtEngineerSurname.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 163);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 0;
            label9.Text = "Surname:";
            // 
            // btnCarEngineerForm
            // 
            btnCarEngineerForm.BackColor = SystemColors.Highlight;
            btnCarEngineerForm.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCarEngineerForm.ForeColor = SystemColors.ControlText;
            btnCarEngineerForm.Location = new Point(18, 637);
            btnCarEngineerForm.Name = "btnCarEngineerForm";
            btnCarEngineerForm.Size = new Size(1692, 57);
            btnCarEngineerForm.TabIndex = 4;
            btnCarEngineerForm.Text = "Car Engineer Form";
            btnCarEngineerForm.UseVisualStyleBackColor = false;
            btnCarEngineerForm.Click += btnCarEngineerForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 706);
            Controls.Add(btnCarEngineerForm);
            Controls.Add(groupBox1);
            Controls.Add(grpCar);
            Controls.Add(grpPeople);
            Controls.Add(grpLicensePlates);
            Name = "Form1";
            Text = "Form1";
            grpLicensePlates.ResumeLayout(false);
            grpLicensePlates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlates).EndInit();
            grpPeople.ResumeLayout(false);
            grpPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            grpCar.ResumeLayout(false);
            grpCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEngineers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLicensePlates;
        private Label label1;
        private Button btnDeletePlate;
        private Button btnUpdatePlate;
        private Button btnAddPlate;
        private TextBox txtPlateNumber;
        private DataGridView dgvPlates;
        private Label lblSelectedPlate;
        private GroupBox grpPeople;
        private Label lblSelectedPerson;
        private DataGridView dgvPeople;
        private Button btnDeletePerson;
        private Button btnUpdatePerson;
        private Button btnAddPerson;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private GroupBox grpCar;
        private TextBox txtBrand;
        private Label label4;
        private Label lblSelectedCar;
        private DataGridView dgvCars;
        private Button btnDeleteCar;
        private Button btnUpdateCar;
        private Button btnAddCar;
        private TextBox txtColor;
        private Label lblColor;
        private Label label5;
        private Label label6;
        private ComboBox cmbLicensePlates;
        private ComboBox cmbOwners;
        private GroupBox groupBox1;
        private TextBox txtEngineerName;
        private Label label7;
        private Label lblSelectedEngineer;
        private DataGridView dgvEngineers;
        private Button btnDeleteEngineer;
        private Button btnUpdateEngineer;
        private Button btnAddEngineer;
        private TextBox txtEngineerSurname;
        private Label label9;
        private Button btnCarEngineerForm;
    }
}
