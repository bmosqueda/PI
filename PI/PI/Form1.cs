using System;
using System.Windows.Forms;

namespace PI
{
    public partial class Form1 : Form
    {
        int preguntaMostrada = 1;
        int inicio;
        int preguntaActual;
        Random r = new Random();

        public void esconderPreguntas()
        {
            lblNumPregunta.Hide();
            lblPregunta.Hide();
        }

        public void esconderResultado()
        {
            lblResultado.Hide();
        }

        public void esconderOpciones()
        {
            bttnA.Hide();
            bttnB.Hide();
            bttnC.Hide();
            bttnD.Hide();
        }

        public void esconderSiguiente()
        {
            bttnSigPregunta.Hide();
        }

        public void mostrarPreguntas()
        {
            lblNumPregunta.Show();
            lblPregunta.Show();
        }

        public void mostrarResultado()
        {
            lblResultado.Show();
        }

        public void mostrarOpciones()
        {
            bttnA.Show();
            bttnB.Show();
            bttnC.Show();
            bttnD.Show();
        }

        public void mostrarSiguiente()
        {
            bttnSigPregunta.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            esconderPreguntas();
            esconderResultado();
            esconderOpciones();
            esconderSiguiente();
        }

        private void bttnA_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            esconderOpciones();
            mostrarSiguiente();
            if (bttnA.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto";
            }
        }

        private void bttnB_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            esconderOpciones();
            mostrarSiguiente();
            if (bttnA.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto";
            }
        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            esconderOpciones();
            mostrarSiguiente();
            if (bttnA.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto";
            }
        }

        private void bttnD_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            esconderOpciones();
            mostrarSiguiente();
            if (bttnA.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto";
            }
        }

        private void bttnIniciar_Click(object sender, EventArgs e)
        {
            bttnIniciar.Hide();
            obtenerNumPregunta();
            mostrarPreguntas();
            mostrarOpciones();
            inicio = r.Next(1, 21);
        }

        private void bttnSigPregunta_Click(object sender, EventArgs e)
        {
            obtenerNumPregunta();
            esconderSiguiente();
            mostrarPreguntas();
            mostrarOpciones();
            esconderResultado();
            obtenerPregunta();
        }

        public string fijarCorrecta()
        {
            int a = obtenerCorrecta();
            switch (a)
            {
                case 1: return "A";
                case 2: return "B";
                case 3: return "C";
                case 4: return "D";
                default: return "";
            }
        }

        public int obtenerCorrecta()
        {
            int correcta = r.Next(1, 5);
            return correcta;
        }

        public string obtenerPregunta()
        {
            if (inicio > 0 && inicio < 21)
                return inicio.ToString();
            else
                return "HI";
        }

        public string obtenerNumPregunta()
        {
            lblNumPregunta.Text = "Pregunta " + preguntaMostrada + ":";
            preguntaMostrada++;
            return lblNumPregunta.Text;
        }
    }
}
