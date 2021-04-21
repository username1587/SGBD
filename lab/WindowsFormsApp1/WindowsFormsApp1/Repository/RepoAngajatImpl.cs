using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.models;
using model.validator;

namespace WindowsFormsApp1.Repository
{
    public class RepoAngajatImpl : IRepoAngajat
    {
        private SqlConnection connection;
        private DataSet ds;

        public RepoAngajatImpl(DataSet dataSet)
        {
            connection =
                new SqlConnection(
                    "Data Source=DESKTOP-KGSJIFP\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
            ds = dataSet;
        }

        public void getAllAngajatiOfRestaurant(Restaurant restaurant)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Angajati", connection);
            ds.Clear();
            
            connection.Open();
            da.Fill(ds,"Angajati");
            connection.Close();
        }

        public void update(Angajat updatedAngajat)
        {
            connection.Open();

            SqlCommand command =
                new SqlCommand(
                    "UPDATE Angajati SET nume=@numeParam, functie=@functieParam, salariu=@salariuParam WHERE id_angajat = @idAngajat",
                    connection);

            SqlParameter parameterNume = new SqlParameter("@numeParam", SqlDbType.VarChar);
            parameterNume.Value = updatedAngajat.Nume;
            command.Parameters.Add(parameterNume);

            SqlParameter parameterFunctie = new SqlParameter("@functieParam", SqlDbType.VarChar);
            parameterFunctie.Value = updatedAngajat.functie;
            command.Parameters.Add(parameterFunctie);

            SqlParameter parameterSalariu = new SqlParameter("@salariuParam", SqlDbType.Int);
            parameterSalariu.Value = updatedAngajat.Salariu;
            command.Parameters.Add(parameterSalariu);

            SqlParameter parameterAngajatId = new SqlParameter("@idAngajat", SqlDbType.Int);
            parameterAngajatId.Value = updatedAngajat.ID;
            command.Parameters.Add(parameterAngajatId);

            var result = command.ExecuteNonQuery();

            connection.Close();

            if (result != 1)
                throw new ValidationException("result should be 1");
        }

        public void add(Angajat newAngajat)
        {
            connection.Open();

            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO Angajati(Nume,functie,Salariu,ID_Restaurant) VALUES (@numeParam,@functieParam,@salariuParam,@idRestaurantParam)",
                    connection);

            // SqlParameter parameterId = new SqlParameter("@idParam", SqlDbType.Int);
            // parameterId.Value = newAngajat.ID;
            // command.Parameters.Add(parameterId);

            SqlParameter parameterNume = new SqlParameter("@numeParam", SqlDbType.VarChar);
            parameterNume.Value = newAngajat.Nume;
            command.Parameters.Add(parameterNume);

            SqlParameter parameterFunctie = new SqlParameter("@functieParam", SqlDbType.VarChar);
            parameterFunctie.Value = newAngajat.functie;
            command.Parameters.Add(parameterFunctie);

            SqlParameter parameterSalariu = new SqlParameter("@salariuParam", SqlDbType.Int);
            parameterSalariu.Value = newAngajat.Salariu;
            command.Parameters.Add(parameterSalariu);

            SqlParameter idRestaurantParameter = new SqlParameter("@idRestaurantParam", SqlDbType.Int);
            idRestaurantParameter.Value = newAngajat.ID_Restaurant;
            command.Parameters.Add(idRestaurantParameter);

            var result = command.ExecuteNonQuery();

            connection.Close();

            if (result != 1)
                throw new ValidationException("result should be 1");
        }

        public void remove(Angajat AngajatToRemove)
        {
            connection.Open();

            SqlCommand command =
                new SqlCommand(
                    "DELETE FROM Angajati WHERE id_angajat = @id",
                    connection);

            SqlParameter idAngajat = new SqlParameter("@id", SqlDbType.Int);
            idAngajat.Value = AngajatToRemove.ID;
            command.Parameters.Add(idAngajat);

            var result = command.ExecuteNonQuery();

            connection.Close();

            if (result != 1)
                throw new ValidationException("result should be 1");
        }

        //fara data adapter si data set
        //         public List<Angajat> getAllAngajatiOfRestaurant(Restaurant restaurant)
        // {
        //     List<Angajat> res = new List<Angajat>();
        //     connection.Open();
        //     SqlCommand command = new SqlCommand("SELECT * FROM Angajati WHERE id_restaurant = @idRes", connection);
        //     SqlParameter parameterRestaurant = new SqlParameter("@idRes", SqlDbType.Int);
        //     parameterRestaurant.Value = restaurant.ID;
        //     command.Parameters.Add(parameterRestaurant);
        //     using (SqlDataReader reader = command.ExecuteReader())
        //     {
        //         while (reader.Read())
        //         {
        //             Angajat angajat = new Angajat()
        //             {
        //                 ID = reader.GetInt32(0),
        //                 Nume = reader.GetString(1),
        //                 functie = reader.GetString(2),
        //                 Salariu = reader.GetInt32(3),
        //                 ID_Restaurant = reader.GetInt32(4)
        //                 // ID = (int)reader[0],
        //                 // Nume = (string)reader[1],
        //                 // functie = (string)reader[2],
        //                 // Salariu = (int)reader[3],
        //                 // ID_Restaurant = (int)reader[4]
        //             };
        //             res.Add(angajat);
        //         }
        //     }
        //
        //     connection.Close();
        //     return res;
        // }
        //
        // public void update(Angajat updatedAngajat)
        // {
        //     connection.Open();
        //
        //     SqlCommand command =
        //         new SqlCommand(
        //             "UPDATE Angajati SET nume=@numeParam, functie=@functieParam, salariu=@salariuParam WHERE id_angajat = @idAngajat",
        //             connection);
        //
        //     SqlParameter parameterNume = new SqlParameter("@numeParam", SqlDbType.VarChar);
        //     parameterNume.Value = updatedAngajat.Nume;
        //     command.Parameters.Add(parameterNume);
        //
        //     SqlParameter parameterFunctie = new SqlParameter("@functieParam", SqlDbType.VarChar);
        //     parameterFunctie.Value = updatedAngajat.functie;
        //     command.Parameters.Add(parameterFunctie);
        //
        //     SqlParameter parameterSalariu = new SqlParameter("@salariuParam", SqlDbType.Int);
        //     parameterSalariu.Value = updatedAngajat.Salariu;
        //     command.Parameters.Add(parameterSalariu);
        //
        //     SqlParameter parameterAngajatId = new SqlParameter("@idAngajat", SqlDbType.Int);
        //     parameterAngajatId.Value = updatedAngajat.ID;
        //     command.Parameters.Add(parameterAngajatId);
        //     
        //     var result = command.ExecuteNonQuery();
        //
        //     connection.Close();
        //
        //     if (result != 1)
        //         throw new ValidationException("result should be 1");
        //     
        // }
        //
        // public void add(Angajat newAngajat)
        // {
        //     connection.Open();
        //
        //     SqlCommand command =
        //         new SqlCommand(
        //             "INSERT INTO Angajati(Nume,functie,Salariu,ID_Restaurant) VALUES (@numeParam,@functieParam,@salariuParam,@idRestaurantParam)",
        //             connection);
        //
        //     // SqlParameter parameterId = new SqlParameter("@idParam", SqlDbType.Int);
        //     // parameterId.Value = newAngajat.ID;
        //     // command.Parameters.Add(parameterId);
        //     
        //     SqlParameter parameterNume = new SqlParameter("@numeParam", SqlDbType.VarChar);
        //     parameterNume.Value = newAngajat.Nume;
        //     command.Parameters.Add(parameterNume);
        //     
        //     SqlParameter parameterFunctie = new SqlParameter("@functieParam", SqlDbType.VarChar);
        //     parameterFunctie.Value = newAngajat.functie;
        //     command.Parameters.Add(parameterFunctie);
        //     
        //     SqlParameter parameterSalariu = new SqlParameter("@salariuParam", SqlDbType.Int);
        //     parameterSalariu.Value = newAngajat.Salariu;
        //     command.Parameters.Add(parameterSalariu);
        //     
        //     SqlParameter idRestaurantParameter = new SqlParameter("@idRestaurantParam", SqlDbType.Int);
        //     idRestaurantParameter.Value = newAngajat.ID_Restaurant;
        //     command.Parameters.Add(idRestaurantParameter);
        //     
        //     var result = command.ExecuteNonQuery();
        //
        //     connection.Close();
        //
        //     if (result != 1)
        //         throw new ValidationException("result should be 1");
        // }
        //
        // public void remove(Angajat AngajatToRemove)
        // {
        //     connection.Open();
        //
        //     SqlCommand command =
        //         new SqlCommand(
        //             "DELETE FROM Angajati WHERE id_angajat = @id",
        //             connection);
        //     
        //     SqlParameter idAngajat = new SqlParameter("@id", SqlDbType.Int);
        //     idAngajat.Value = AngajatToRemove.ID;
        //     command.Parameters.Add(idAngajat);
        //     
        //     var result = command.ExecuteNonQuery();
        //     
        //     connection.Close();
        //     
        //     if (result != 1)
        //         throw new ValidationException("result should be 1");
        // }
        //#endregion
    }
}