using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_Project
{
    public partial class DbForm : Form
    {
        public DbForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-9Q5HHL4\SQLEXPRESS;Initial Catalog=my_db;User ID=sa;Password=admin";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into dbo.people(id, name) values (4,'" + "Neha" + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            /*     while(dataReader.Read())
      {
          output= output + dataReader.GetValue(0) + "-" +dataReader.GetValue(1) + "\n";
      }

      MessageBox.Show(output);


      dataReader.Close();

  */
            command.Dispose();
            //     MessageBox.Show("Connection Open  !");
            cnn.Close();
        }


        private void DbForm_Load(object sender, EventArgs e)
        {

        }
    }
}
