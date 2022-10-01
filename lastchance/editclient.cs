using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastchance
{
    public partial class editclient : Form
    {
        string id;
        static string connectionstring = "Data Source=DESKTOP-SDEPRKC;Initial Catalog=inventory_mangment;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);
        DataTable dt = new DataTable();

        public void loadform(object Form)
        {
            if (this.Controls.Count > 0)
                this.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            this.Tag = f;
            f.Show();
        }

        public editclient(string id)
        {
            InitializeComponent();
            this.id = id;
            con.Open();
            string query = "select * from client where c_id = "+id;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            con.Close();
            namebox.Text = dt.Rows[0].Field<string>(1);
            phone.Text = dt.Rows[0].Field<string>(2);
            level.Text = (dt.Rows[0].Field<int>(3)).ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new clients());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand( "UPDATE client SET name = @name, phone = @ph , level = @le Where c_id = @id " , con);
            cmd.Parameters.AddWithValue("@name", namebox.Text.ToString());
            cmd.Parameters.AddWithValue("@ph", phone.Text.ToString());
            cmd.Parameters.AddWithValue("@le", level.Text.ToString());
            cmd.Parameters.AddWithValue("@id", id);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted Successfully.");
                loadform(new clients());

            }
            else
                MessageBox.Show("error inserting Data");
            con.Close();
        }
    }
}
