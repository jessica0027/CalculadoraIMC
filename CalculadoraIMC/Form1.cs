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

        private void txtPesoEnter(object sender, EventArgs e) // Quando selecionado o campo de Peso mudar� a cor  
        {
            txtPeso.BackColor = Color.Red; // Comando que muda a cor para vermelho
            txtPeso.Tag = true; // Comando que ativa o campo Peso quando selecionado
            txtAltura.Tag = false; // Comando que desmarca o campo Altura
        }

        private void txtAlturaEnter(object sender, EventArgs e) // Quando selecionado o campo de Altura mudar� a cor
        {
            txtAltura.BackColor = Color.Red; // Comando que muda a cor para vermelho
            txtAltura.Tag = true; //  Comando que ativa o campo Altura quando selecionado
            txtPeso.Tag = false; // Comando que desmarca o campo Peso
        }

        private void txtAltura_Leave(object sender, EventArgs e) 
        {
            txtAltura.BackColor = Color.White; // Quando sai do campo Altura volta para cor branca
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.White; // Quando sai do campo Peso volta para cor branca
        }

        private void AddNumeros(object sender, EventArgs e) //Evento que adiciona n�meros ao campo ativo
        {
            Button numeros = sender as Button;

            if (txtAltura.Tag != null && txtAltura.Tag.Equals(true))
            {
                txtAltura.Text += numeros.Text; // Adiciona n�meros ao campo Altura
            }
            else
            {
                txtPeso.Text += numeros.Text; // Adiciona n�meros ao campo Peso
            }
        }

        private void btVirgula_Click(object sender, EventArgs e) // Fun��o que verifica se existe v�rgula antes de adicionar e caso exista n�o � impedido de adicionar mais de uma v�rgula, caso ainda n�o contenha � adicionaod uma v�rgula
        {
            if (btVirgula.Text == ",") // Verifica se h� v�rgula e se n�o houver permite que adicione v�rgula
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

        private void btDel_Click(object sender, EventArgs e) // Fun��o para limpar o campo selecionado apenas (Limpa a Altura ou o Peso)
        {
            if (txtAltura.Tag.Equals(true)) // Limpa o campo Altura quando estiver selecionado
            {
                txtAltura.Clear();
            }

            if (txtPeso.Tag.Equals(true))
            {
                txtPeso.Clear(); // Limpa o campo Peso quando estiver selecionado
            }

        }

        private void btCalculo_Click(object sender, EventArgs e)
        {
            double peso, altura;
            if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text)) // Fun��o que verifica se o campo est� vazio 
            {
                lblMensagemErro.Text = "Os campos Peso e Altura n�o podem estar vazios.";
                lblMensagemErro.ForeColor = Color.Red;
                return;
            }
            lblMensagemErro.Text = "";

            if (!double.TryParse(txtPeso.Text, out peso) || !double.TryParse(txtAltura.Text, out altura)) // Fun��o que verifica se o n�mero digitado � v�lido
            {
                lblMensagemErro.Text = "Digite valores v�lidos para Peso e Altura.";
                lblMensagemErro.ForeColor = Color.Red;
                return;
            }
            lblMensagemErro.Text = "";

            // Fun��o / comando para calcular o IMC
            double imc = peso / Math.Pow(altura, 2);
            txtImc.Text = imc.ToString("N2");

            if (imc < 19.1) // Resultado da soma que aparecer� na label caso o IMC for menor que 19,1
            {
                lbResultadoSituacao.Text = "Abaixo do Peso";
            }

            else if (imc >= 19.1 && imc < 25.8) // Resultado da soma que aparecer� na label caso o IMC for igual ou maior que 19,1 e menor que 25,8
            {
                lbResultadoSituacao.Text = "Peso Normal";
            }

            else if (imc >= 25.8 && imc < 32.3) // Resultado da soma que aparecer� na label caso o IMC for igual ou maior que 25,8 e menor que 32,3
            {
                lbResultadoSituacao.Text = "Acima do Peso";
            }

            else if (imc >= 32.3) // Resultado da soma que aparecer� na label caso o IMC for igual ou maior que 32,3
            {
                lbResultadoSituacao.Text = "Obeso";
            }


        }
    }
}
