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
            switch (inicio)
            {
                case 1: return "1";
                case 2: return "2";
                case 3: return "3";
                case 4: return "4";
                case 5: return "5";
                case 6: return "6";
                case 7: return "7";
                case 8: return "8";
                case 9: return "9";
                case 10: return "10";
                case 11: return "11";
                case 12: return "12";
                case 13: return "13";
                case 14: return "14";
                case 15: return "15";
                case 16: return "16";
                case 17: return "17";
                case 18: return "18";
                case 19: return "19";
                case 20: return "20";
                default: return "HI";
            }
        }

        public string obtenerNumPregunta()
        {
            lblNumPregunta.Text = "Pregunta " + preguntaMostrada + ":";
            preguntaMostrada++;
            return lblNumPregunta.Text;
        }
    }
}
