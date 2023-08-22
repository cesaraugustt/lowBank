namespace lowBankWindows
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // this.Location = new Point(Location.X + e.X, Location.Y + e.Y);
                Point newLocation = new Point(
                    this.Location.X + e.X - offset.X,
                    this.Location.Y + e.Y - offset.Y
                );
                this.Location = newLocation;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}