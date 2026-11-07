namespace T2S2Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool NuevaOperacion = true;
        private bool TerminarOperacion = false;
        private double Valor1 = 0;
        private double Valor2 = 0;
        private string Operador = "";
        private void escribirNumero(string numero)
        {
            if (TerminarOperacion)
            {
                label_historial.Text = "";
                TerminarOperacion = false;
            }
            if (NuevaOperacion)
            {
                txt_resultados.Text = numero;
                NuevaOperacion = false;
            }
            else
            {
                txt_resultados.Text += numero;
            }
            if (Operador != "")
            {
                label_historial.Text = Valor1 + " " + Operador + " " + txt_resultados.Text;
            }
        }
        private void ColocarOperador(string operador)
        {
            Valor1 = double.TryParse(txt_resultados.Text, out Valor1) ? Valor1 : 0;
            Operador = operador;
            NuevaOperacion = true;
            TerminarOperacion = false;
            actulizarHistorial();
        }
        private void actulizarHistorial()
        {
            label_historial.Text = Valor1 + " " + Operador;
        }
        private void bt_igual_Click(object sender, EventArgs e)
        {
            if (Operador == "")
            {
                return;
            }

            Valor2 = double.TryParse(txt_resultados.Text, out Valor2) ? Valor2 : 0;

            label_historial.Text = Valor1 + " " + Operador + " " + Valor2 + " =";
            switch (Operador)
            {
                case "+":
                    txt_resultados.Text = (Valor1 + Valor2).ToString();
                    break;
                case "-":
                    txt_resultados.Text = (Valor1 - Valor2).ToString();
                    break;
                case "*":
                    txt_resultados.Text = (Valor1 * Valor2).ToString();
                    break;
                case "/":
                    if (Valor2 != 0)
                    {
                        txt_resultados.Text = (Valor1 / Valor2).ToString();
                    }
                    else
                    {
                        txt_resultados.Text = "Error";
                    }
                    break;
                default:
                    break;
            }
            NuevaOperacion = true;
            TerminarOperacion = true;
            Operador = "";
        }

        private void label_historial_Click(object sender, EventArgs e)
        {

        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            escribirNumero("0");
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            escribirNumero("1");
        }


        private void bt_2_Click(object sender, EventArgs e)
        {
            escribirNumero("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            escribirNumero("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            escribirNumero("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            escribirNumero("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            escribirNumero("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            escribirNumero("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            escribirNumero("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            escribirNumero("9");
        }

        private void txt_resultados_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt_suma_Click(object sender, EventArgs e)
        {
            ColocarOperador("+");
        }

        private void bt_resta_Click(object sender, EventArgs e)
        {
            ColocarOperador("-");
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            ColocarOperador("*");
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            ColocarOperador("/");
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            txt_resultados.Text = "0";
            label_historial.Text = "";
            Valor1 = 0;
            Valor2 = 0;
            Operador = "";
            NuevaOperacion = true;
            TerminarOperacion = false;
        }

        private void bt_punto_Click(object sender, EventArgs e)
        {
            string separador = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (NuevaOperacion)
            {
                escribirNumero("0" + separador);       
            }
            else if (!txt_resultados.Text.Contains(separador))
            {
                escribirNumero(separador);          
            }
        }
    }
}
