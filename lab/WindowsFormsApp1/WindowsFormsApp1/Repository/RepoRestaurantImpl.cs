using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Repository
{
    public class RepoRestaurantImpl : IRepoRestaurant
    {
        private SqlConnection connection;

        public RepoRestaurantImpl()
        {
            connection = new SqlConnection(
                "Data Source=DESKTOP-KGSJIFP\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
        }


        public List<Restaurant> getAll()
        {
            List<Restaurant> restaurants=new List<Restaurant>();
            
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Locatii", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Restaurant restaurant = new Restaurant()
                    {
                        ID = (int)reader[0],
                        Adresa = (string)reader[1]
                    };
                    restaurants.Add(restaurant);
                }
            }

            connection.Close();
            return restaurants;
        }
    }
}