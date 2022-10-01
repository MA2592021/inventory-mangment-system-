
using System.Runtime.InteropServices;
namespace lastchance
{
    public partial class Form1 : Form
    {
        bool dragging = false;
        int xOffset = 0;
        int yOffset = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        

        private static extern IntPtr CreateRoundRectRgn(
            int nleftREct,
            int ntopREct,
            int nRightREct,
            int nBottomREct,
            int nWidthEllipse,
            int nheightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }



        private void btndash_Click(object sender, EventArgs e)
        {
            panelnav.Height = btndash.Height;
            panelnav.Top = btndash.Top;
            panelnav.Left = btndash.Left;
            btndash.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new dashboard());
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            panelnav.Height = btnprod.Height;
            panelnav.Top = btnprod.Top;
            panelnav.Left = btnprod.Left;
            btnprod.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new products());
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            panelnav.Height = btnclient.Height;
            panelnav.Top = btnclient.Top;
            panelnav.Left = btnclient.Left;
            btnclient.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new clients());
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            panelnav.Height = btntrans.Height;
            panelnav.Top = btntrans.Top;
            panelnav.Left = btntrans.Left;
            btntrans.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            panelnav.Height = btnsettings.Height;
            panelnav.Top = btnsettings.Top;
            panelnav.Left = btnsettings.Left;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btndash_Leave(object sender, EventArgs e)
        {
            btndash.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnprod_Leave(object sender, EventArgs e)
        {
            btnprod.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnclient_Leave(object sender, EventArgs e)
        {
            btnclient.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btntrans_Leave(object sender, EventArgs e)
        {
            btntrans.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void closeapp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            panelnav.Height = btncont.Height;
            panelnav.Top = btncont.Top;
            panelnav.Left = btncont.Left;
            btncont.BackColor = Color.FromArgb(46, 51, 73);
            loadform(new containers());
        }

        private void btncont_Leave(object sender, EventArgs e)
        {
            btncont.BackColor = Color.FromArgb(24, 30, 54);

        }



        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;

            xOffset = Cursor.Position.X - this.Location.X;
            yOffset = Cursor.Position.Y - this.Location.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(Cursor.Position.X - xOffset, Cursor.Position.Y - yOffset);
                this.Update();
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
    
}