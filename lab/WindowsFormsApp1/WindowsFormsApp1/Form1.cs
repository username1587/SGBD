using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.models;
using model.validator;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Controller.Controller _controller;

        public Form1(Controller.Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restaurantDataGriedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            angajatiDataGriedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            loadRestauranteDataGriedView();
            loadRestaurantFields();
        }

        private void loadRestauranteDataGriedView()
        {
            restaurantDataGriedView.DataSource = _controller.getAllRestaurants();
        }

        private void loadAngajatiDataGriedView()
        {
            // Restaurant restaurant = 
            var item = (Restaurant) restaurantDataGriedView.SelectedRows[0].DataBoundItem;
            angajatiDataGriedView.DataSource = _controller.getAngajatiOfRestaurant(item);
        }

        private void angajatiDataGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadAngajatiFields();
        }

        private void loadRestaurantFields()
        {
            var item = (Restaurant) restaurantDataGriedView.SelectedRows[0].DataBoundItem;
            restaurantIdTextField.Text = item.ID.ToString();
            adresaRestaurantTextField.Text = item.Adresa;
        }

        private void loadAngajatiFields()
        {
            if (angajatiDataGriedView.SelectedRows.Count == 0)
            {
                angajatIdTextField.Text = "";
                functieTextBox.Text = "";
                salariuTextBox.Text = "";
                numeAngajatTextBox.Text = "";
                return;
            }

            var row = angajatiDataGriedView.SelectedRows[0];
            var item = (Angajat) row.DataBoundItem;
            angajatIdTextField.Text = item.ID.ToString();
            functieTextBox.Text = item.functie;
            salariuTextBox.Text = item.Salariu.ToString();
            numeAngajatTextBox.Text = item.Nume;
        }

        private void restaurantDataGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            angajatiDataGriedView.DataSource = null;
            loadAngajatiDataGriedView();
            loadAngajatiFields();
            loadRestaurantFields();
        }


        private void updateAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                int angajatID;
                string numeAngajat;
                string functie;
                int salariu;
                try
                {
                    angajatID = Int32.Parse(angajatIdTextField.Text);
                    numeAngajat = numeAngajatTextBox.Text;
                    functie = functieTextBox.Text;
                    salariu = Int32.Parse(salariuTextBox.Text);
                }
                catch (ArgumentNullException ex1)
                {
                    errorLabel.Text = "unul din fielduri e gol";
                    return;
                }
                catch (FormatException ex)
                {
                    errorLabel.Text = "unul din fielduri e invalid";
                    return;
                }
                Angajat angajat = new Angajat()
                {
                    functie = functie,
                    Nume = numeAngajat,
                    Salariu = salariu,
                    ID = angajatID
                };
                _controller.updateAngajat(angajat);
                errorLabel.Text = "";
            }
            catch (ValidationException ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void addAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                int angajatID = Int32.Parse(angajatIdTextField.Text);
                string numeAngajat = numeAngajatTextBox.Text;
                string functie = functieTextBox.Text;
                int salariu = Int32.Parse(salariuTextBox.Text);
                Restaurant restaurant = (Restaurant) restaurantDataGriedView.SelectedRows[0].DataBoundItem;
                _controller.addAngajat(angajatID, numeAngajat, functie, salariu, restaurant);
                errorLabel.Text = "";
            }
            catch (ValidationException ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void removeAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                Angajat angajat = (Angajat) angajatiDataGriedView.SelectedRows[0].DataBoundItem;
                _controller.deleteAngajat(angajat);
                errorLabel.Text = "";
            }
            catch (ValidationException ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}