using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Repository
{
    public class RepoRestaurantImpl : IRepoRestaurant
    {
        private SqlConnection connection;
        private DataSet ds;

        public RepoRestaurantImpl(DataSet dataSet)
        {
            connection = new SqlConnection(
                "Data Source=DESKTOP-KGSJIFP\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
            ds = dataSet;
        }


        public void getAll()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM Locatii", connection);
            ds.Clear();
            da.Fill(ds,"Locatii");
        }
    }
}