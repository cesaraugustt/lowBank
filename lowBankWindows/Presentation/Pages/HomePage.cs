using lowBankWindows;

namespace lowBankWindows
{
    public partial class HomePage : Form
    {
        private bool isDragging = false;
        private Point offset;

        private Cliente usuarioLogado;

        public HomePage(Cliente cliente)
        {
            usuarioLogado = cliente;
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {

            //Atribuir o nome no label do formulario
            textoBemVindo.Text = "Bem vindo, " + usuarioLogado.Nome + "!";

            //Atribuir o saldo no label do cartão
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioLogado.Saldo += 10;
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarioLogado.Saldo -= 10;
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");
        }
    }
}