using ANK17CodeFirstRelationships.Context;
using ANK17CodeFirstRelationships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK17CodeFirstRelationships
{
    public partial class CarEngineerForm : Form
    {
        private CarDbContext _db;
        CarEngineer selectedCarEngineer;
        private object lblSelectedCarEngineer;

        public CarEngineerForm(CarDbContext db)
        {
            _db = db;
            InitializeComponent();
            ListCars();
            ListEngineers();
            ListCarEngineers();
        }

        private void ListCars()
        {
            cmbCars.Items.Add("Select Car");
            cmbCars.Items.AddRange(_db.Cars.ToArray());
            cmbCars.SelectedIndex = 0;
        }
        private void ListEngineers()
        {
            cmbEngineers.Items.Add("Select Engineer");
            cmbEngineers.Items.AddRange(_db.Engineers.ToArray());
            cmbEngineers.SelectedIndex = 0;
        }
        private void ListCarEngineers()
        {
            dgvCarEngineers.DataSource = _db.CarEngineers.ToList();
        }
        private void btnAddCarEngineer_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a car!");
                return;
            }
            if (cmbEngineers.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an engineer!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumberOfDays.Text))
            {
                MessageBox.Show("Please write number of working days");
                return;
            }
            if (int.TryParse(txtNumberOfDays.Text, out int days) == false)
            {
                MessageBox.Show("Please write number for working days!");
                return;
            }

            if (days <= 0)
            {
                MessageBox.Show("Please write positive numbers for working days");
                return;
            }


            CarEngineer carEngineer = new CarEngineer();

            carEngineer.EngineerId = ((Engineer)cmbEngineers.SelectedItem).Id;
            carEngineer.CarId = ((Car)cmbCars.SelectedItem).Id;
            carEngineer.NumberOfDays = days;

            _db.CarEngineers.Add(carEngineer);
            _db.SaveChanges();

            ListCarEngineers();
            MessageBox.Show("Engineer-Car data has been added");

        }
        private void dgvCarEngineers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCarEngineer = (CarEngineer)dgvCarEngineers.SelectedRows[0].DataBoundItem;
            // seçilen bilgilerini comboboxlara ve textboxlarda göster

            txtNumberOfDays.Text = selectedCarEngineer.NumberOfDays.ToString();
            cmbCars.SelectedItem = selectedCarEngineer.Car;
            cmbEngineers.SelectedItem = selectedCarEngineer.Engineer;

            lblSelectedCarEngineer = "Selected Car Engineer: " + selectedCarEngineer.Car.Brand + " " + selectedCarEngineer.Car.Color + " " + selectedCarEngineer.Engineer.Name + " " + selectedCarEngineer.Engineer.SurName + " " + selectedCarEngineer.NumberOfDays;
        }



    }
}
