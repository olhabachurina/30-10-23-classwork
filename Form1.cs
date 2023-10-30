using System.Windows.Forms;

namespace _30_10_23_classwork
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel flowLayoutPanel;

        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectImagesButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(fileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;

                    flowLayoutPanel.Controls.Add(pictureBox);
                }
            }
        }

       
    }
}
