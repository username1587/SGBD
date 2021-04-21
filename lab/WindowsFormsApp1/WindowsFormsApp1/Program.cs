using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ICopilRepo copilRepo = new CopilRepo();
            // IProbaRepo probaRepo = new ProbaRepo();
            // IProbaCopilRepo probaCopilRepo = new ProbaCopilRepo(probaRepo,copilRepo);
            // IUserRepo userRepo = new UserRepo();
            // IServices server = new ServerImpl(copilRepo,probaCopilRepo,probaRepo,userRepo);

            // SqlConnection cs =
            //     new SqlConnection(
            //         "Data Source=DESKTOP-KGSJIFP\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");
            // SqlDataAdapter da = new SqlDataAdapter();
            // // DataSet ds = new DataSet();
            // BindingSource bs = new BindingSource();
            //
            // cs.Open();
            // SqlCommand command = new SqlCommand("SELECT * FROM Locatii", cs);
            // // ds.Clear();
            // // da.Fill(ds);
            // using(SqlDataReader reader = command.ExecuteReader())
            // {
            //     while (reader.Read())
            //     {
            //         Console.WriteLine(String.Format("{0}, {1}",
            //             reader[0], reader[1]));
            //     }
            // }

            DataSet ds = new DataSet();
            
            IRepoRestaurant repoRestaurant=new RepoRestaurantImpl(ds);
            IRepoAngajat repoAngajat=new RepoAngajatImpl();

            IService service = new Service.Service(repoAngajat,repoRestaurant);

            Controller.Controller controller = new Controller.Controller(service,ds);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1(controller));
        }
    }
}