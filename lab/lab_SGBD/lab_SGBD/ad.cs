// namespace Companii221
// {
//     public partial class Form1 : Form
//     {
//         string connectionString = "Server=DESKTOP-KQN5LR3;Database=seminar2221sgbd;Integrated Security=true";
//         DataSet ds = new DataSet();
//         SqlDataAdapter adapterParent = new SqlDataAdapter();
//         SqlDataAdapter adapterChild = new SqlDataAdapter();
//         BindingSource bsParent = new BindingSource();
//         BindingSource bsChild = new BindingSource();
//         public Form1()
//         {
//             InitializeComponent();
//         }
//
//         private void Form1_Load(object sender, EventArgs e)
//         {
//             this.Text = "Companii si angajati";
//             try
//             {
//                 using(SqlConnection connection = new SqlConnection(connectionString))
//                 {
//                     connection.Open();
//                     adapterParent.SelectCommand = new SqlCommand("SELECT * FROM Companii;", connection);
//                     adapterChild.SelectCommand = new SqlCommand("SELECT * FROM Angajati;", connection);
//                     adapterParent.Fill(ds, "Companii");
//                     adapterChild.Fill(ds, "Angajati");
//                     label1.Text = "Companii";
//                     label2.Text = "Angajati";
//                     bsParent.DataSource = ds.Tables["Companii"];
//                     dataGridView1.DataSource = bsParent;
//                     DataColumn pk = ds.Tables["Companii"].Columns["id"];
//                     DataColumn fk = ds.Tables["Angajati"].Columns["id_companie"];
//                     DataRelation relation = new DataRelation("fk_Companii_Angajati", pk, fk);
//                     ds.Relations.Add(relation);
//                     bsChild.DataSource = bsParent;
//                     bsChild.DataMember = "fk_Companii_Angajati";
//                     dataGridView2.DataSource = bsChild;
//                 }
//             }
//             catch(Exception ex)
//             {
//                 MessageBox.Show(ex.Message);
//             }
//         }
//     }
// }