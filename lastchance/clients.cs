using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastchance
{
    public partial class clients : Form
    {
        static string connectionstring = "Data Source=DESKTOP-SDEPRKC;Initial Catalog=inventory_mangment;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);
        DataTable dt = new DataTable();
        string id;
        public clients()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(c_id) from client", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nopro.Text = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();
            con.Open();
            string query = "select * from client  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            StyleDatagridview();
        }

 
        private void searchbox_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "name like '%" + searchbox.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void searchbox_Click_1(object sender, EventArgs e)
        {
            searchbox.Text = "";
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
        private void searchbtn_Click_1(object sender, EventArgs e)
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
            dataGridView1.Columns[4].Width =
                dataGridView1.Width
                - dataGridView1.Columns[0].Width
                - dataGridView1.Columns[1].Width - dataGridView1.Columns[3].Width- dataGridView1.Columns[2].Width - 60;  // this is an extra "margin" number of pixels
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            loadform(new add());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // test.Text = dataGridView1.SelectedCells[0].Value.ToString();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                test.Text = row.Cells[0].Value.ToString();
                id = row.Cells[0].Value.ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (id == null) { MessageBox.Show("select client to edit"); }
            else { loadform(new editclient(id)); }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id == null) { MessageBox.Show("select client to delete"); }
            else {  
            string message = "a7a?";
            string title = "delete client";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM client WHERE c_id = @id; ", con);
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data deleted Successfully.");
                    loadform(new clients());

                }
                else
                    MessageBox.Show("error inserting Data");
                con.Close();
            }
            }
        }
    }
}
