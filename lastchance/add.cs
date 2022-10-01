using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lastchance
{
    public partial class add : Form
    {
        static string connectionstring = "Data Source=DESKTOP-SDEPRKC;Initial Catalog=inventory_mangment;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);
        DataTable dt = new DataTable();
        public add()
        {
            InitializeComponent();
        }
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

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new clients());
        }

        private void btnnew_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into client values('" + namebox.Text + "', '" + phone.Text + "', '" + int.Parse(level.Text) + "' , GETDATE())", con);
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
