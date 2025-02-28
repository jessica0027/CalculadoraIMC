using System.Web;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Calculadora : Form
    {
        
        public Calculadora()
        {
            InitializeComponent();
           
        }

        private void txtPesoEnter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtPeso.Tag = true;
            txtAltura.Tag = false;
        }

        private void txtAlturaEnter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtAltura.Tag = true;
            txtPeso.Tag = false;
        }

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.White;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.White;
        }

        private void AddNumeros(object sender, EventArgs e)
        {
            Button numeros = sender as Button;

            if (txtAltura.Tag != null && txtAltura.Tag.Equals(true))
            {
                txtAltura.Text += numeros.Text;
            }
            else
            {
                txtPeso.Text += numeros.Text;
            }
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (btVirgula.Text == ",")
            {
                if (txtAltura.Text != "" && !txtAltura.Text.Contains(","))
                {
                    txtAltura.Text += ",";
                }
                else if (txtPeso.Text != "" && !txtPeso.Text.Contains(","))
                {
                    txtPeso.Text += ",";
                }


            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtAltura.Tag.Equals(true))
            {
                txtAltura.Clear();

            }

            if (txtPeso.Tag.Equals(true))
            {
                txtPeso.Clear();
            }

        }

        private void btCalculo_Click(object sender, EventArgs e)
        {
            double peso, altura;
            if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                lblMensagemErro.Text = "Os campos Peso e Altura não podem estar vazios.";
                lblMensagemErro.ForeColor = Color.Red;
                return;
            }

            if (!double.TryParse(txtPeso.Text, out peso) || !double.TryParse(txtAltura.Text, out altura))
            {
               lblMensagemErro.Text = "Digite valores válidos para Peso e Altura.";
               lblMensagemErro.ForeColor = Color.Red;
                return;
            }
            
            double imc = peso / Math.Pow(altura, 2);
            txtImc.Text = imc.ToString("N2");

            if (imc < 19.1) 
            {
                lbResultadoSituacao.Text = "Abaixo do Peso";
            }

            else if (imc >= 19.1 && imc < 25.8) 
            {
                lbResultadoSituacao.Text = "Peso Normal";
            }

            else if (imc >= 25.8 && imc < 32.3) 
            {
                lbResultadoSituacao.Text = "Acima do Peso";
            }

            else if (imc >= 32.3) 
            {
                lbResultadoSituacao.Text = "Obeso";
            }

           
        }
    }
}

