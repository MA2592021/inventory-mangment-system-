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

namespace lastchance
{
    public partial class containers : Form
    {
        static string connectionstring = "Data Source=DESKTOP-SDEPRKC;Initial Catalog=inventory_mangment;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);
        static DataTable dt = new DataTable();
        DataView dv = new DataView(dt);
        public containers()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(con_id)  from container  ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nopro.Text = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();
            con.Open();
            string query = "select con_id,name,price_on_land as 'factory price',dep_date , CASE when container.status = 0 then 'didnt arrived' else 'arrived' end as status from container";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            StyleDatagridview();
        }


        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "name like '%" + searchbox.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void searchbox_Click(object sender, EventArgs e)
        {
            searchbox.Text = "";

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchbox.Text = "";

        }


        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[3].Width =
                dataGridView1.Width
                - dataGridView1.Columns[0].Width
                - dataGridView1.Columns[1].Width - dataGridView1.Columns[2].Width - dataGridView1.Columns[4].Width - 60;  // this is an extra "margin" number of pixels
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            test.Text = dataGridView1.SelectedCells[0].Value.ToString();

        }
    }
}
