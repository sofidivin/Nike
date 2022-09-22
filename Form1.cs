using Nike.userControl;

namespace Nike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            addUserControl(uc);
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new UserControl2();
            addUserControl(uc);
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            addUserControl(uc);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            UserControl4 uc = new UserControl4();
            addUserControl(uc);
        }

        private void btn_precio_Click(object sender, EventArgs e)
        {
            UserControl5 uc = new UserControl5();
            addUserControl(uc);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}