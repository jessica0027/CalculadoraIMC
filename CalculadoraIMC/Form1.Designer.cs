namespace CalculadoraIMC
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            panel2 = new Panel();
            btZero = new Button();
            btVirgula = new Button();
            btDel = new Button();
            btCalculo = new Button();
            btUm = new Button();
            btDois = new Button();
            btTres = new Button();
            btQuatro = new Button();
            btCinco = new Button();
            btSeis = new Button();
            btSete = new Button();
            btOito = new Button();
            btNove = new Button();
            lbSubtitulo = new Label();
            lbTitulo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbPeso = new Label();
            lbAltura = new Label();
            lbIMC = new Label();
            panel1 = new Panel();
            lblMensagemErro = new Label();
            lbMensagemErro = new Label();
            lbResultadoSituacao = new Label();
            lbSituacao = new Label();
            lbM = new Label();
            lbKg = new Label();
            txtImc = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btZero);
            panel2.Controls.Add(btVirgula);
            panel2.Controls.Add(btDel);
            panel2.Controls.Add(btCalculo);
            panel2.Controls.Add(btUm);
            panel2.Controls.Add(btDois);
            panel2.Controls.Add(btTres);
            panel2.Controls.Add(btQuatro);
            panel2.Controls.Add(btCinco);
            panel2.Controls.Add(btSeis);
            panel2.Controls.Add(btSete);
            panel2.Controls.Add(btOito);
            panel2.Controls.Add(btNove);
            panel2.Location = new Point(12, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 314);
            panel2.TabIndex = 4;
            // 
            // btZero
            // 
            btZero.BackColor = Color.Gold;
            btZero.Font = new Font("Verdana", 14.25F);
            btZero.Location = new Point(149, 217);
            btZero.Name = "btZero";
            btZero.Size = new Size(70, 58);
            btZero.TabIndex = 20;
            btZero.Text = "0";
            btZero.UseVisualStyleBackColor = false;
            btZero.Click += AddNumeros;
            // 
            // btVirgula
            // 
            btVirgula.BackColor = Color.Gold;
            btVirgula.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btVirgula.Location = new Point(44, 217);
            btVirgula.Name = "btVirgula";
            btVirgula.Size = new Size(70, 58);
            btVirgula.TabIndex = 19;
            btVirgula.Text = ",";
            btVirgula.UseVisualStyleBackColor = false;
            btVirgula.Click += btVirgula_Click;
            // 
            // btDel
            // 
            btDel.BackColor = Color.Gold;
            btDel.Font = new Font("Verdana", 14.25F);
            btDel.Location = new Point(254, 217);
            btDel.Name = "btDel";
            btDel.Size = new Size(70, 58);
            btDel.TabIndex = 18;
            btDel.Text = "Del";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btCalculo
            // 
            btCalculo.BackColor = Color.Gold;
            btCalculo.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCalculo.Location = new Point(44, 281);
            btCalculo.Name = "btCalculo";
            btCalculo.Size = new Size(280, 23);
            btCalculo.TabIndex = 14;
            btCalculo.Text = "Calcular Índice de Massa Corporal";
            btCalculo.UseVisualStyleBackColor = false;
            btCalculo.Click += btCalculo_Click;
            // 
            // btUm
            // 
            btUm.BackColor = Color.Gold;
            btUm.Font = new Font("Verdana", 14.25F);
            btUm.Location = new Point(44, 153);
            btUm.Name = "btUm";
            btUm.Size = new Size(70, 58);
            btUm.TabIndex = 10;
            btUm.Text = "1";
            btUm.UseVisualStyleBackColor = false;
            btUm.Click += AddNumeros;
            // 
            // btDois
            // 
            btDois.BackColor = Color.Gold;
            btDois.Font = new Font("Verdana", 14.25F);
            btDois.Location = new Point(149, 153);
            btDois.Name = "btDois";
            btDois.Size = new Size(70, 58);
            btDois.TabIndex = 9;
            btDois.Text = "2";
            btDois.UseVisualStyleBackColor = false;
            btDois.Click += AddNumeros;
            // 
            // btTres
            // 
            btTres.BackColor = Color.Gold;
            btTres.Font = new Font("Verdana", 14.25F);
            btTres.Location = new Point(254, 153);
            btTres.Name = "btTres";
            btTres.Size = new Size(70, 58);
            btTres.TabIndex = 8;
            btTres.Text = "3";
            btTres.UseVisualStyleBackColor = false;
            btTres.Click += AddNumeros;
            // 
            // btQuatro
            // 
            btQuatro.BackColor = Color.Gold;
            btQuatro.Font = new Font("Verdana", 14.25F);
            btQuatro.ForeColor = Color.Black;
            btQuatro.Location = new Point(44, 89);
            btQuatro.Name = "btQuatro";
            btQuatro.Size = new Size(70, 58);
            btQuatro.TabIndex = 7;
            btQuatro.Text = "4";
            btQuatro.UseVisualStyleBackColor = false;
            btQuatro.Click += AddNumeros;
            // 
            // btCinco
            // 
            btCinco.BackColor = Color.Gold;
            btCinco.Font = new Font("Verdana", 14.25F);
            btCinco.Location = new Point(149, 89);
            btCinco.Name = "btCinco";
            btCinco.Size = new Size(70, 58);
            btCinco.TabIndex = 6;
            btCinco.Text = "5";
            btCinco.UseVisualStyleBackColor = false;
            btCinco.Click += AddNumeros;
            // 
            // btSeis
            // 
            btSeis.BackColor = Color.Gold;
            btSeis.Font = new Font("Verdana", 14.25F);
            btSeis.Location = new Point(254, 89);
            btSeis.Name = "btSeis";
            btSeis.Size = new Size(70, 58);
            btSeis.TabIndex = 5;
            btSeis.Text = "6";
            btSeis.UseVisualStyleBackColor = false;
            btSeis.Click += AddNumeros;
            // 
            // btSete
            // 
            btSete.BackColor = Color.Gold;
            btSete.Font = new Font("Verdana", 14.25F);
            btSete.Location = new Point(44, 25);
            btSete.Name = "btSete";
            btSete.Size = new Size(70, 58);
            btSete.TabIndex = 4;
            btSete.Text = "7";
            btSete.UseVisualStyleBackColor = false;
            btSete.Click += AddNumeros;
            // 
            // btOito
            // 
            btOito.BackColor = Color.Gold;
            btOito.Font = new Font("Verdana", 14.25F);
            btOito.Location = new Point(149, 25);
            btOito.Name = "btOito";
            btOito.Size = new Size(70, 58);
            btOito.TabIndex = 3;
            btOito.Text = "8";
            btOito.UseVisualStyleBackColor = false;
            btOito.Click += AddNumeros;
            // 
            // btNove
            // 
            btNove.BackColor = Color.Gold;
            btNove.Font = new Font("Verdana", 14.25F);
            btNove.Location = new Point(254, 25);
            btNove.Name = "btNove";
            btNove.Size = new Size(70, 58);
            btNove.TabIndex = 2;
            btNove.Text = "9";
            btNove.UseVisualStyleBackColor = false;
            btNove.Click += AddNumeros;
            // 
            // lbSubtitulo
            // 
            lbSubtitulo.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSubtitulo.ForeColor = Color.DimGray;
            lbSubtitulo.Location = new Point(3, 47);
            lbSubtitulo.Name = "lbSubtitulo";
            lbSubtitulo.Size = new Size(371, 23);
            lbSubtitulo.TabIndex = 5;
            lbSubtitulo.Text = "Informe seu Peso e Altura";
            lbSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitulo
            // 
            lbTitulo.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(3, 14);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(371, 33);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Cálculo de IMC";
            lbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lbPeso
            // 
            lbPeso.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPeso.ForeColor = Color.DimGray;
            lbPeso.Location = new Point(112, 77);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(97, 32);
            lbPeso.TabIndex = 8;
            lbPeso.Text = "Peso";
            lbPeso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbAltura
            // 
            lbAltura.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAltura.ForeColor = Color.DimGray;
            lbAltura.Location = new Point(112, 127);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(97, 32);
            lbAltura.TabIndex = 9;
            lbAltura.Text = "Altura";
            lbAltura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbIMC
            // 
            lbIMC.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbIMC.ForeColor = Color.DimGray;
            lbIMC.Location = new Point(112, 177);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(97, 32);
            lbIMC.TabIndex = 10;
            lbIMC.Text = "IMC";
            lbIMC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(lblMensagemErro);
            panel1.Controls.Add(lbMensagemErro);
            panel1.Controls.Add(lbResultadoSituacao);
            panel1.Controls.Add(lbSituacao);
            panel1.Controls.Add(lbM);
            panel1.Controls.Add(lbKg);
            panel1.Controls.Add(txtImc);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(lbIMC);
            panel1.Controls.Add(lbAltura);
            panel1.Controls.Add(lbPeso);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbTitulo);
            panel1.Controls.Add(lbSubtitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 266);
            panel1.TabIndex = 3;
            // 
            // lblMensagemErro
            // 
            lblMensagemErro.AutoSize = true;
            lblMensagemErro.Location = new Point(31, 206);
            lblMensagemErro.Name = "lblMensagemErro";
            lblMensagemErro.Size = new Size(10, 15);
            lblMensagemErro.TabIndex = 19;
            lblMensagemErro.Text = ",";
            // 
            // lbMensagemErro
            // 
            lbMensagemErro.Location = new Point(16, 221);
            lbMensagemErro.Name = "lbMensagemErro";
            lbMensagemErro.Size = new Size(348, 13);
            lbMensagemErro.TabIndex = 18;
            // 
            // lbResultadoSituacao
            // 
            lbResultadoSituacao.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbResultadoSituacao.Location = new Point(174, 234);
            lbResultadoSituacao.Name = "lbResultadoSituacao";
            lbResultadoSituacao.Size = new Size(187, 23);
            lbResultadoSituacao.TabIndex = 17;
            // 
            // lbSituacao
            // 
            lbSituacao.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSituacao.ForeColor = Color.DimGray;
            lbSituacao.Location = new Point(44, 231);
            lbSituacao.Name = "lbSituacao";
            lbSituacao.Size = new Size(124, 32);
            lbSituacao.TabIndex = 16;
            lbSituacao.Text = "Situação";
            lbSituacao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbM
            // 
            lbM.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbM.ForeColor = Color.DimGray;
            lbM.Location = new Point(330, 127);
            lbM.Name = "lbM";
            lbM.Size = new Size(44, 32);
            lbM.TabIndex = 15;
            lbM.Text = "m";
            lbM.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbKg
            // 
            lbKg.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbKg.ForeColor = Color.DimGray;
            lbKg.Location = new Point(330, 77);
            lbKg.Name = "lbKg";
            lbKg.Size = new Size(44, 32);
            lbKg.TabIndex = 14;
            lbKg.Text = "kg";
            lbKg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtImc
            // 
            txtImc.Enabled = false;
            txtImc.Location = new Point(224, 177);
            txtImc.Multiline = true;
            txtImc.Name = "txtImc";
            txtImc.Size = new Size(100, 32);
            txtImc.TabIndex = 13;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(224, 127);
            txtAltura.Multiline = true;
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 32);
            txtAltura.TabIndex = 12;
            txtAltura.Enter += txtAlturaEnter;
            txtAltura.Leave += txtAltura_Leave;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(224, 77);
            txtPeso.Multiline = true;
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 32);
            txtPeso.TabIndex = 11;
            txtPeso.Enter += txtPesoEnter;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(394, 610);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Calculadora";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lbSubtitulo;
        private Label lbTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbPeso;
        private Label lbAltura;
        private Label lbIMC;
        private Panel panel1;
        private TextBox txtImc;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label lbM;
        private Label lbKg;
        private Label lbSituacao;
        private Button btSete;
        private Button btOito;
        private Button btNove;
        private Label lbResultadoSituacao;
        private Button btCalculo;
        private Button btUm;
        private Button btDois;
        private Button btTres;
        private Button btQuatro;
        private Button btCinco;
        private Button btSeis;
        private Button btZero;
        private Button btVirgula;
        private Button btDel;
        private Label lbMensagemErro;
        private Label lblMensagemErro;
    }
}
