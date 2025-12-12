namespace NetCoreFudamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Solo escribimos aqui
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!";
            this.txtNombre.Width = 220;
            this.txtNombre.BackColor = Color.Fuchsia;
            //No es conversion automatica
            short pequeño = 88;
            int mayor = pequeño; //al reves te daria error al compilar sino le haces casting
            //Casting
            int pequeñoo = 88;
            short mayorr = (short) pequeño;
            //string a primitivo
            string textoNumero = "Hoy es viernes";
            int numero = int.Parse(textoNumero);
            double otro = double.Parse(textoNumero);
            //Convertir cualquier objeto a string
            string dato = this.btnPulsar.ToString();
        }
    }
}
