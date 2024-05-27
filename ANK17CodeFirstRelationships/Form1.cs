using ANK17CodeFirstRelationships.Context;
using ANK17CodeFirstRelationships.Entities;
using System.Xml.Serialization;

namespace ANK17CodeFirstRelationships
{
    public partial class Form1 : Form
    {
        CarDbContext _db = new CarDbContext();
        CarEngineerForm carEngineerForm;
        LicensePlate selectedPlate;
        Person selectedPerson;
        Car selectedCar;
        Engineer selectedEngineer;

        public Form1()
        {

            InitializeComponent();
            ListPlates();
            ListPeople();
            ListCars();
            ListEngineers();
            carEngineerForm = new CarEngineerForm(_db);

            //Yeni bir araba oluşturalım..
            //Önce yeni bir plaka ekleyelim...

            //LicensePlate licensePlate = new LicensePlate();
            //licensePlate.Number = "67ABC227";

            //_db.LicensePlates.Add(licensePlate);    
            //_db.SaveChanges();


            //Person person = new Person();
            //person.Name = "Reyhan";
            //person.Surname = "Yıldız";
            //_db.People.Add(person);
            //_db.SaveChanges();

            //LicensePlate licensePlate = new LicensePlate();
            //licensePlate.Number = "66ABC200";
            //_db.LicensePlates.Add(licensePlate);
            //_db.SaveChanges();





            //Car car = new Car();
            //car.Brand = "MG";
            //car.Color = "Beyaz";
            //car.LicensePlateId = 3;
            //car.PersonId = 2;

            //_db.Cars.Add(car);
            //_db.SaveChanges();


            //var araba = _db.Cars.Find(5);

            //CarEngineer carEngineer = new CarEngineer();
            //carEngineer.EngineerId = 1;
            //carEngineer.CarId = 2;
            //carEngineer.NumberOfDays = 60;

            //_db.CarEngineers.Add(carEngineer);  
            //_db.SaveChanges();

            //var m1 = _db.Engineers.Find(1);

            //var m2 = _db.Engineers.FirstOrDefault(a => a.Id == 1);


        }

        private void ListPlates()
        {
            var plates = _db.LicensePlates.ToList();
            dgvPlates.DataSource = plates;
            cmbLicensePlates.Items.Clear();
            cmbLicensePlates.Items.Add("Plaka Seçiniz");
            cmbLicensePlates.Items.AddRange(plates.ToArray());
            cmbLicensePlates.SelectedIndex = 0;
        }
        private void ListPeople()
        {
            var owners = _db.People.ToList();
            dgvPeople.DataSource = owners;
            cmbOwners.Items.Clear();
            cmbOwners.Items.Add("Sahip Seçiniz");
            cmbOwners.Items.AddRange(owners.ToArray());
            cmbOwners.SelectedIndex = 0;

        }
        private void ListCars()
        {
            dgvCars.DataSource = _db.Cars.ToList();
        }
        private void ListEngineers()
        {
            dgvEngineers.DataSource = _db.Engineers.ToList();
        }
        private void ResetSelectedPlate()
        {
            selectedPlate = null;
            lblSelectedPlate.Text = "Selected Plate";
        }
        private void ResetSelectedPerson()
        {
            selectedPerson = null;
            lblSelectedPerson.Text = "Selected Person";
        }
        private void ResetSelectedCar()
        {
            selectedCar = null;
            lblSelectedCar.Text = "Selected Car";
        }
        private void ResetSelectedEngineer()
        {
            selectedEngineer = null;
            lblSelectedEngineer.Text = "Selected Engineer";
        }

        private void btnAddPlate_Click(object sender, EventArgs e)
        {
            try
            {
                LicensePlate licensePlate = new LicensePlate();
                licensePlate.Number = txtPlateNumber.Text;

                _db.LicensePlates.Add(licensePlate);
                _db.SaveChanges();
                ListPlates();
                MessageBox.Show("License plate has successfully been added");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!!!" + ex.Message);
            }
        }

        private void btnUpdatePlate_Click(object sender, EventArgs e)
        {
            if (selectedPlate != null) //gridden seçildiyse güncelle
            {
                selectedPlate.Number = txtPlateNumber.Text;
                _db.SaveChanges();
                ListPlates();
                ResetSelectedPlate();
                MessageBox.Show("License plate has successfully been updated");
            }
            else
            {
                MessageBox.Show("Please select a plate to update");
            }
        }

        private void dgvPlates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPlate = (LicensePlate)dgvPlates.SelectedRows[0].DataBoundItem;
            lblSelectedPlate.Text = "Selected Plate: " + selectedPlate.Id + " " + selectedPlate.Number;
            txtPlateNumber.Text = selectedPlate.Number;
        }

        private void btnDeletePlate_Click(object sender, EventArgs e)
        {
            if (selectedPlate != null)
            {
                _db.LicensePlates.Remove(selectedPlate);
                _db.SaveChanges();
                ListPlates();
                ResetSelectedPlate();
                MessageBox.Show("License plate has successfully been deleted");
            }
            else
            {
                MessageBox.Show("Please select a plate to delete");
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                };

                _db.People.Add(person);
                _db.SaveChanges();
                ListPeople();
                MessageBox.Show("Person has successfully been registered");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!!!" + ex.Message);
            }

        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null) //gridden seçildiyse güncelle
            {
                selectedPerson.Name = txtName.Text;
                selectedPerson.Surname = txtSurname.Text;
                _db.SaveChanges();
                ListPeople();
                ResetSelectedPerson();
                MessageBox.Show("Person has successfully been updated");
            }
            else
            {
                MessageBox.Show("Person to update");
            }

        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
            {
                _db.Remove(selectedPerson);
                _db.SaveChanges();
                ListPeople();
                ResetSelectedPerson();
                MessageBox.Show("Person has successfully been deleted");
            }
            else
            {
                MessageBox.Show("Please select a person to delete");
            }

        }

        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPerson = (Person)dgvPeople.SelectedRows[0].DataBoundItem;
            lblSelectedPerson.Text = "Selected Person: " + selectedPerson.Id + " " + selectedPerson.Name + " " + selectedPerson.Surname;
            txtName.Text = selectedPerson.Name;
            txtSurname.Text = selectedPerson.Surname;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var selectedPlateId = ((LicensePlate)cmbLicensePlates.SelectedItem).Id;
            var secilenPlakayıKullananArabaMi = _db.Cars.Any(c => c.LicensePlateId == selectedPlateId);

            if (secilenPlakayıKullananArabaMi)
            {
                MessageBox.Show("The plate you have selected has already been used.Please select anoyher plate");
                return;
            }

            Car car = new Car();
            car.Brand = txtBrand.Text;
            car.Color = txtColor.Text;
            //car.LicensePlateId = selectedPlateId;
            //car.PersonId = ((Person)cmbOwners.SelectedItem).Id;

            if (selectedPlateId != 0)
            {
                car.LicensePlateId = selectedPlateId;
            }

            else
            {
                car.LicensePlateId = null;
            }

            if (cmbOwners.SelectedIndex != 0)
            {
                car.PersonId = ((Person)cmbOwners.SelectedItem).Id;
            }
            _db.Cars.Add(car);
            _db.SaveChanges();
            ListCars();

            MessageBox.Show("Car has successfully been added");

        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCar = (Car)dgvCars.SelectedRows[0].DataBoundItem;
            lblSelectedCar.Text = "Selected Car: " + selectedCar.Id + " " + selectedCar.LicensePlate.Number;

            if (selectedCar.LicensePlate != null)
            {
                lblSelectedCar.Text = "Selected Car: " + selectedCar.Id + " " + selectedCar.LicensePlate.Number;
            }
            else
            {
                lblSelectedCar.Text = "Selected Car: " + selectedCar.Id + " " + "Plaka Yok";
            }

            txtBrand.Text = selectedCar.Brand;
            txtColor.Text = selectedCar.Color;


            if (selectedCar.LicensePlateId != null)

                cmbLicensePlates.SelectedItem = selectedCar.LicensePlate;
            else
                cmbLicensePlates.SelectedItem = "Plaka Seçiniz";



            if (selectedCar.PersonId != null)

                cmbOwners.SelectedItem = selectedCar.Person;
            else
                cmbOwners.SelectedIndex = 0;


        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (selectedCar != null)
            {
                var selectedPlateId = ((LicensePlate)cmbLicensePlates.SelectedItem).Id;
                var secilenPlakayıKullananArabaMi = _db.Cars.Any(c => c.LicensePlateId == selectedPlateId);

                if (_db.Cars.Any(c => c.LicensePlateId == selectedPlateId && c.Id != selectedCar.Id))
                {
                    MessageBox.Show("The plate you have selected has already been used.Please select anoyher plate to update");
                    return;
                }
                selectedCar.Brand = txtBrand.Text;
                selectedCar.Color = txtColor.Text;
                //car.LicensePlateId = selectedPlateId;
                //car.PersonId = ((Person)cmbOwners.SelectedItem).Id;

                if (selectedPlateId != 0)
                {
                    selectedCar.LicensePlateId = selectedPlateId;
                }

                else
                {
                    selectedCar.LicensePlateId = null;
                }

                if (cmbOwners.SelectedIndex != 0)
                {
                    selectedCar.PersonId = ((Person)cmbOwners.SelectedItem).Id;
                }
                _db.SaveChanges();
                ResetSelectedCar();
                ListCars();

                MessageBox.Show("Car has successfully been added");
            }
            else
                MessageBox.Show("Please select a car to update!");
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (selectedCar != null)
            {
                _db.Remove(selectedCar);
                _db.SaveChanges();
                ListPeople();
                ResetSelectedCar();
                MessageBox.Show("Car has successfully been deleted");
            }
            else
            {
                MessageBox.Show("Please select a car to delete");
            }

        }

        private void btnAddEngineer_Click(object sender, EventArgs e)
        {
            try
            {
                Engineer engineer = new Engineer()
                {
                    Name = txtEngineerName.Text,
                    SurName = txtEngineerSurname.Text,
                };

                _db.Engineers.Add(engineer);
                _db.SaveChanges();
                ListEngineers();
                MessageBox.Show("Engineer has successfully been registered");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!!!" + ex.Message);
            }
        }

        private void dgvEngineers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEngineer = (Engineer)dgvEngineers.SelectedRows[0].DataBoundItem;
            lblSelectedEngineer.Text = "Selected Engineer: " + selectedEngineer.Id + " " + selectedEngineer.Name + " " + selectedEngineer.SurName;
            txtEngineerName.Text = selectedPerson.Name;
            txtEngineerSurname.Text = selectedEngineer.SurName;
        }

        private void btnUpdateEngineer_Click(object sender, EventArgs e)
        {
            if (selectedEngineer != null) //gridden seçildiyse güncelle
            {
                selectedEngineer.Name = txtEngineerName.Text;
                selectedEngineer.SurName = txtEngineerSurname.Text;
                _db.SaveChanges();
                ListEngineers();
                ResetSelectedEngineer();
                MessageBox.Show("Engineer has successfully been updated");
            }
            else
            {
                MessageBox.Show("Person to update");
            }
        }

        private void btnDeleteEngineer_Click(object sender, EventArgs e)
        {
            if (selectedEngineer != null)
            {
                _db.Remove(selectedEngineer);
                _db.SaveChanges();
                ListEngineers();
                ResetSelectedEngineer();
                MessageBox.Show("Engineer has successfully been deleted");
            }
            else
            {
                MessageBox.Show("Please select a engineer to delete");
            }
        }

        private void btnCarEngineerForm_Click(object sender, EventArgs e)
        {
            carEngineerForm.ShowDialog();
        }
    }
}


//1-m için
/* Foreign eklenecek sınıfa foreign key eklenir ve yine karşı taraf cinsinden navigation prop eklenir. (TEKİL) 
 * (gelenekten gidelim dersek: sınıfadı+id
 * Karşı tarafa da (foreign olmayan tarafa) SADECE karşı taraf cinsinden navigation prop eklenir. (LİSTE) 
 * 
 */

//m-n için
/* 1.yol:
 * Many to many için sınıf açılır.
 * Primary key eklenir. (eklemeden diğer foreign keylerle composite key de yapılabilir.) (Sonra)
 * İçerisine, ilişkide olan sınıflar cinsinden foreign key ve navigation proplar eklenir. (TEKİL)
 * 
 * Many to many'nin ilişkide olduğu bütün sınıflara, yukarıda oluşturduğumuz many to many tipinde LİSTE eklenir. (navigation prop.)
 * 
 */