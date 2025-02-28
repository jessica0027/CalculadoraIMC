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
        // Quando selecionado o campo de Peso mudará a cor
        {
            txtPeso.BackColor = Color.Red; // Comando que muda a cor para vermelho
            txtPeso.Tag = true; // Comando que ativa o campo peso quando selecionado
            txtAltura.Tag = false; // Comando que desmarca o campo altura
        }

        private void txtAlturaEnter(object sender, EventArgs e)
        //
        {
            txtAltura.BackColor = Color.Red; // Comando que muda a cor para vermelho
            txtAltura.Tag = true; // Comando que ativa o campo altura quando selecionado
            txtPeso.Tag = false; // Comando que desmarca o campo peso
        }
        }

        private void txtAltura_Leave(object sender, EventArgs e)
        // Quando sai do campo altura volta para cor branca
        {
            txtAltura.BackColor = Color.White; 
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        // Quando sai do campo peso volta para cor branca
        {
        txtPeso.BackColor = Color.White;
        }

        private void AddNumeros(object sender, EventArgs e)
        // Função que adiciona números ao campo ativo
        {
            Button numeros = sender as Button;

            // Adiciona números ao campo altura
            if (txtAltura.Tag != null && txtAltura.Tag.Equals(true))
            {
                txtAltura.Text += numeros.Text;
            }
            
            // Adiciona números ao campo peso
            else
            {
                txtPeso.Text += numeros.Text;
            }
        }

        private void btVirgula_Click(object sender, EventArgs e)
        // Função que verifica se existe vírgula antes de adicionar e caso exista não é impedido de adicionar mais de uma vírgula, caso ainda não contenha é adicionaod uma vírgula
        {
            // Verificação e adiciona a vírgula
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
        // Função para limpar o campo selecionado apenas (Limpa a altura ou o peso)
        {
            // Limpa o campo altura quando estiver selecionado
            if (txtAltura.Tag.Equals(true))
            {
                txtAltura.Clear();

            }
            // Limpa o campo peso quando estiver selecionado
            if (txtPeso.Tag.Equals(true))
            {
                txtPeso.Clear();
            }

        }

        private void btCalculo_Click(object sender, EventArgs e)
        // Função que verifica se o campo está vazio ou se foi adicionado um número válido
        {
            double peso, altura; // Variavéis declaradas peso e altura
            // Verifica se o campo peso e/ou altura está vazio
            if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                lblMensagemErro.Text = "Os campos Peso e Altura não podem estar vazios.";
                lblMensagemErro.ForeColor = Color.Red;
                return;
            }

            //Verifica se o campo peso e/ou altura está com números válidos
            if (!double.TryParse(txtPeso.Text, out peso) || !double.TryParse(txtAltura.Text, out altura))
            {
               lblMensagemErro.Text = "Digite valores válidos para Peso e Altura.";
               lblMensagemErro.ForeColor = Color.Red;
                return;
            }
            
            // Função/comando para calcular o IMC
            double imc = peso / Math.Pow(altura, 2);
            txtImc.Text = imc.ToString("N2");
            
            // Resultado da soma que aparecerá na label caso o IMC for menor que 19,1
            if (imc < 19.1) 
            {
                lbResultadoSituacao.Text = "Abaixo do Peso";
            }

            // Resultado da soma que aparecerá na label caso o IMC for igual ou maior que 19,1 e menor que 25,8
            else if (imc >= 19.1 && imc < 25.8) 
            {
                lbResultadoSituacao.Text = "Peso Normal";
            }

            // Resultado da soma que aparecerá na label caso o IMC for igual ou maior que 25,8 e menor que 32,3
            else if (imc >= 25.8 && imc < 32.3) 
            {
                lbResultadoSituacao.Text = "Acima do Peso";
            }

            // Resultado da soma que aparecerá na label caso o IMC for igual ou maior que 32,3
            else if (imc >= 32.3) 
            {
                lbResultadoSituacao.Text = "Obeso";
            }

           
        }
    }
}

