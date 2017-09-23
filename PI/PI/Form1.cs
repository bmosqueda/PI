using System;
using System.Windows.Forms;

namespace PI
{
    public partial class Form1 : Form
    {
        int preguntaMostrada = 1;
        int inicio = 1;
        int correcta;
        Random r = new Random();

        public void fijarIncisoCorrecto()
        {
            int a = correcta;
            switch (a)
            {
                case 1:
                    lblA.Text = obtenerIncisoCorrecto();
                    lblB.Text = obtenerIncisoInorrecto1();
                    lblC.Text = obtenerIncisoInorrecto2();
                    lblD.Text = obtenerIncisoInorrecto3();
                    break;
                case 2:
                    lblA.Text = obtenerIncisoInorrecto1();
                    lblB.Text = obtenerIncisoCorrecto();
                    lblC.Text = obtenerIncisoInorrecto2();
                    lblD.Text = obtenerIncisoInorrecto3();
                    break;
                case 3:
                    lblA.Text = obtenerIncisoInorrecto1();
                    lblB.Text = obtenerIncisoInorrecto2();
                    lblC.Text = obtenerIncisoCorrecto();
                    lblD.Text = obtenerIncisoInorrecto3();
                    break;
                case 4:
                    lblA.Text = obtenerIncisoInorrecto1();
                    lblB.Text = obtenerIncisoInorrecto2();
                    lblC.Text = obtenerIncisoInorrecto3();
                    lblD.Text = obtenerIncisoCorrecto();
                    break;
            }
        }

        public void esconderPreguntas()
        {
            lblNumPregunta.Hide();
            lblPregunta.Hide();
        }

        public void esconderResultado()
        {
            lblResultado.Hide();
        }

        public void esconderIncisos()
        {
            lblA.Hide();
            lblB.Hide();
            lblC.Hide();
            lblD.Hide();
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

        public void mostrarIncisos()
        {
            lblA.Show();
            lblB.Show();
            lblC.Show();
            lblD.Show();
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
            lblFin.Hide();
            esconderIncisos();
        }

        private void bttnA_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            mostrarSiguiente();
            esconderOpciones();
            if (bttnA.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto\n Respuesta correcta: " + fijarCorrecta();
            }
        }

        private void bttnB_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            mostrarSiguiente();
            esconderOpciones();
            if (bttnB.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto\n Respuesta correcta: " + fijarCorrecta();
            }
        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            mostrarSiguiente();
            esconderOpciones();
            if (bttnC.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto\n Respuesta correcta: " + fijarCorrecta();
            }
        }

        private void bttnD_Click(object sender, EventArgs e)
        {
            esconderPreguntas();
            mostrarResultado();
            mostrarSiguiente();
            esconderOpciones();
            if (bttnD.Text == fijarCorrecta())
            {
                lblResultado.Text = "Correcto";
            }
            else
            {
                lblResultado.Text = "Incorrecto\n Respuesta correcta: " + fijarCorrecta();
            }
        }

        private void bttnIniciar_Click(object sender, EventArgs e)
        {
            bttnIniciar.Hide();
            obtenerNumPregunta();
            mostrarPreguntas();
            mostrarOpciones();
            lblPregunta.Text = obtenerPregunta();
            inicio++;
            correcta = r.Next(1, 5);
            lblBienvenido.Hide();
            mostrarIncisos();
            fijarIncisoCorrecto();
        }

        private void bttnSigPregunta_Click(object sender, EventArgs e)
        {
            if (preguntaMostrada <= 20)
            {
                correcta = r.Next(1, 5);
                obtenerNumPregunta();
                esconderSiguiente();
                mostrarPreguntas();
                mostrarOpciones();
                esconderResultado();
                obtenerPregunta();
                mostrarIncisos();
                fijarIncisoCorrecto();
                lblPregunta.Text = obtenerPregunta();
                inicio++;
            }
            else
            {
                lblFin.Show();
                lblResultado.Hide();
                esconderSiguiente();
                esconderIncisos();
            }
        }

        public string fijarCorrecta()
        {
            int a = correcta;
            switch (a)
            {
                case 1: return "A";
                case 2: return "B";
                case 3: return "C";
                case 4: return "D";
                default: return "";
            }
        }

        public string obtenerPregunta()
        {
            if (inicio > 0 && inicio < 21)
                return inicio.ToString();
            else
                return "HI";
        }

        public string obtenerIncisoCorrecto()
        {
            switch (inicio)
            {
                case 1: return "C";
                case 2: return "C";
                case 3: return "C";
                case 4: return "C";
                case 5: return "C";
                case 6: return "C";
                case 7: return "C";
                case 8: return "C";
                case 9: return "C";
                case 10: return "C";
                case 11: return "C";
                case 12: return "C";
                case 13: return "C";
                case 14: return "C";
                case 15: return "C";
                case 16: return "C";
                case 17: return "C";
                case 18: return "C";
                case 19: return "C";
                case 20: return "C";
                default: return "HI";
            }
        }

        public string obtenerIncisoInorrecto1()
        {
            switch (inicio)
            {
                case 1: return "I";
                case 2: return "I";
                case 3: return "I";
                case 4: return "I";
                case 5: return "I";
                case 6: return "I";
                case 7: return "I";
                case 8: return "I";
                case 9: return "I";
                case 10: return "I";
                case 11: return "I";
                case 12: return "I";
                case 13: return "I";
                case 14: return "I";
                case 15: return "I";
                case 16: return "I";
                case 17: return "I";
                case 18: return "I";
                case 19: return "I";
                case 20: return "I";
                default: return "HI";
            }
        }

        public string obtenerIncisoInorrecto2()
        {
            switch (inicio)
            {
                case 1: return "I";
                case 2: return "I";
                case 3: return "I";
                case 4: return "I";
                case 5: return "I";
                case 6: return "I";
                case 7: return "I";
                case 8: return "I";
                case 9: return "I";
                case 10: return "I";
                case 11: return "I";
                case 12: return "I";
                case 13: return "I";
                case 14: return "I";
                case 15: return "I";
                case 16: return "I";
                case 17: return "I";
                case 18: return "I";
                case 19: return "I";
                case 20: return "I";
                default: return "HI";
            }
        }

        public string obtenerIncisoInorrecto3()
        {
            switch (inicio)
            {
                case 1: return "I";
                case 2: return "I";
                case 3: return "I";
                case 4: return "I";
                case 5: return "I";
                case 6: return "I";
                case 7: return "I";
                case 8: return "I";
                case 9: return "I";
                case 10: return "I";
                case 11: return "I";
                case 12: return "I";
                case 13: return "I";
                case 14: return "I";
                case 15: return "I";
                case 16: return "I";
                case 17: return "I";
                case 18: return "I";
                case 19: return "I";
                case 20: return "I";
                default: return "HI";
            }
        }

        public string obtenerNumPregunta()
        {
            lblNumPregunta.Text = "Pregunta " + preguntaMostrada + ":";
            preguntaMostrada++;
            return lblNumPregunta.Text;
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
