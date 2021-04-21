using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter angajatiDataAdapter = new SqlDataAdapter();
        private SqlDataAdapter restauranteDataAdapter = new SqlDataAdapter();
        private BindingSource bsParent = new BindingSource();
        private BindingSource bsChild = new BindingSource();


        private SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-KGSJIFP\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");

        private const String RestaurantTable = "Restaurante";
        private const String AngajatiTable = "Angajati";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restaurantDataGriedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            angajatiDataGriedView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            connection.Open();

            restauranteDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Locatii", connection);
            // dataSet.Clear();
            restauranteDataAdapter.Fill(dataSet, RestaurantTable);
            bsParent.DataSource = dataSet.Tables[RestaurantTable];
            restaurantDataGriedView.DataSource = bsParent;
            loadRestaurantFields();

            angajatiDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Angajati", connection);
            angajatiDataAdapter.Fill(dataSet, AngajatiTable);

            DataColumn pk = dataSet.Tables[RestaurantTable].Columns["id_restaurant"];
            DataColumn fk = dataSet.Tables[AngajatiTable].Columns["id_restaurant"];
            DataRelation relation = new DataRelation("fk_Restaurante_Angajati", pk, fk);
            dataSet.Relations.Add(relation);

            // angajatiDataAdapter.Fill(dataSet,AngajatiTable)
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_Restaurante_Angajati";
            angajatiDataGriedView.DataSource = bsChild;

            setRestaurantLabelsBindings();
            setAngajatiLabelsBindings();

            connection.Close();
        }

        private void setRestaurantLabelsBindings()
        {
            restaurantIdTextField.DataBindings.Add("Text", bsParent, "id_restaurant");
            adresaRestaurantTextField.DataBindings.Add("Text", bsParent, "adresa");
        }

        private void setAngajatiLabelsBindings()
        {
            angajatIdTextField.DataBindings.Add("Text", bsChild, "id_angajat");
            numeAngajatTextBox.DataBindings.Add("Text", bsChild, "nume");
            functieTextBox.DataBindings.Add("Text", bsChild, "functie");
            salariuTextBox.DataBindings.Add("Text", bsChild, "salariu");
        }

        private void loadRestauranteDataGriedView()
        {
        }

        private void loadAngajatiDataGriedView()
        {
        }


        private void angajatiDataGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void loadRestaurantFields()
        {
        }

        private void loadAngajatiFields()
        {
        }

        private void restaurantDataGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadAngajatiDataGriedView();
        }


        private void updateAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                angajatiDataAdapter.UpdateCommand = new SqlCommand(
                    "UPDATE Angajati SET nume=@nume,functie=@functie,salariu=@salariu where id_angajat=@id", connection);

                angajatiDataAdapter.UpdateCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value =
                    numeAngajatTextBox.Text;
                angajatiDataAdapter.UpdateCommand.Parameters.Add("@functie", SqlDbType.VarChar).Value =
                    functieTextBox.Text;
                angajatiDataAdapter.UpdateCommand.Parameters.Add("@salariu", SqlDbType.Int).Value =
                    Int32.Parse(salariuTextBox.Text);
                angajatiDataAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value =
                    Int32.Parse(angajatIdTextField.Text);
                
                connection.Open();
                angajatiDataAdapter.UpdateCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void addAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                angajatiDataAdapter.InsertCommand = new SqlCommand(
                    "INSERT INTO Angajati VALUES (@nume,@functie,@salariu,@id_restaurant)", connection);

                angajatiDataAdapter.InsertCommand.Parameters.Add("@nume", SqlDbType.VarChar).Value =
                    numeAngajatTextBox.Text;
                angajatiDataAdapter.InsertCommand.Parameters.Add("@functie", SqlDbType.VarChar).Value =
                    functieTextBox.Text;
                angajatiDataAdapter.InsertCommand.Parameters.Add("@salariu", SqlDbType.Int).Value =
                    Int32.Parse(salariuTextBox.Text);
                angajatiDataAdapter.InsertCommand.Parameters.Add("@id_restaurant", SqlDbType.VarChar).Value =
                    Int32.Parse(restaurantIdTextField.Text);
                
                connection.Open();
                angajatiDataAdapter.InsertCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void removeAngajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                angajatiDataAdapter.DeleteCommand = new SqlCommand(
                    "DELETE FROM Angajati WHERE id_angajat=@id ", connection);

                angajatiDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value =
                    Int32.Parse(angajatIdTextField.Text);

                connection.Open();
                angajatiDataAdapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // connection.Open();
            
            restauranteDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Locatii", connection);
            angajatiDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Angajati", connection);

            dataSet.Clear();
            dataSet.Relations.Clear();

            restauranteDataAdapter.Fill(dataSet,RestaurantTable);
            angajatiDataAdapter.Fill(dataSet,AngajatiTable);
            
            restaurantDataGriedView.DataSource = bsParent;
            angajatiDataGriedView.DataSource = bsChild;

            bsParent.DataSource = dataSet.Tables[RestaurantTable];
            // bsChild.DataSource = dataSet.Tables[AngajatiTable];
            
            DataColumn pk = dataSet.Tables[RestaurantTable].Columns["id_restaurant"];
            DataColumn fk = dataSet.Tables[AngajatiTable].Columns["id_restaurant"];
            DataRelation relation = new DataRelation("fk_Restaurante_Angajati", pk, fk);
            dataSet.Relations.Add(relation);
            
            // angajatiDataAdapter.Fill(dataSet,AngajatiTable)
            
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_Restaurante_Angajati";
            angajatiDataGriedView.DataSource = bsChild;
            
            // connection.Close();
        }
    }
}