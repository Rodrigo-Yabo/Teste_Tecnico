namespace Teste_tecnico
{
    partial class FrmCadastroF
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.GpFormularioCad = new System.Windows.Forms.GroupBox();
            this.BtnConsultarCNPJ = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNomeResp = new System.Windows.Forms.TextBox();
            this.MtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LblNomeResp = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblCNPJ = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.MtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.MtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.LblEnderco = new System.Windows.Forms.Label();
            this.LblRua = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.MtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.GpFormularioCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(546, 397);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(109, 49);
            this.BtnCadastro.TabIndex = 23;
            this.BtnCadastro.Text = "Cadastrar";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // GpFormularioCad
            // 
            this.GpFormularioCad.Controls.Add(this.MtxtCnpj);
            this.GpFormularioCad.Controls.Add(this.BtnConsultarCNPJ);
            this.GpFormularioCad.Controls.Add(this.LblNome);
            this.GpFormularioCad.Controls.Add(this.TxtNome);
            this.GpFormularioCad.Controls.Add(this.TxtNomeResp);
            this.GpFormularioCad.Controls.Add(this.MtxtTelefone);
            this.GpFormularioCad.Controls.Add(this.LblNomeResp);
            this.GpFormularioCad.Controls.Add(this.TxtEmail);
            this.GpFormularioCad.Controls.Add(this.LblCNPJ);
            this.GpFormularioCad.Controls.Add(this.LblEmail);
            this.GpFormularioCad.Controls.Add(this.MtxtCEP);
            this.GpFormularioCad.Controls.Add(this.TxtCidade);
            this.GpFormularioCad.Controls.Add(this.MtxtNumero);
            this.GpFormularioCad.Controls.Add(this.LblTelefone);
            this.GpFormularioCad.Controls.Add(this.TxtEstado);
            this.GpFormularioCad.Controls.Add(this.LblEnderco);
            this.GpFormularioCad.Controls.Add(this.LblRua);
            this.GpFormularioCad.Controls.Add(this.LblCEP);
            this.GpFormularioCad.Controls.Add(this.TxtRua);
            this.GpFormularioCad.Controls.Add(this.TxtBairro);
            this.GpFormularioCad.Controls.Add(this.LblNumero);
            this.GpFormularioCad.Controls.Add(this.LblEstado);
            this.GpFormularioCad.Controls.Add(this.LblBairro);
            this.GpFormularioCad.Controls.Add(this.LblCidade);
            this.GpFormularioCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpFormularioCad.Location = new System.Drawing.Point(25, 33);
            this.GpFormularioCad.Name = "GpFormularioCad";
            this.GpFormularioCad.Size = new System.Drawing.Size(563, 358);
            this.GpFormularioCad.TabIndex = 26;
            this.GpFormularioCad.TabStop = false;
            this.GpFormularioCad.Text = "Formulario de Cadastro";
            // 
            // BtnConsultarCNPJ
            // 
            this.BtnConsultarCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCNPJ.Location = new System.Drawing.Point(142, 108);
            this.BtnConsultarCNPJ.Name = "BtnConsultarCNPJ";
            this.BtnConsultarCNPJ.Size = new System.Drawing.Size(70, 23);
            this.BtnConsultarCNPJ.TabIndex = 30;
            this.BtnConsultarCNPJ.Text = "Consultar";
            this.BtnConsultarCNPJ.UseVisualStyleBackColor = true;
            this.BtnConsultarCNPJ.Click += new System.EventHandler(this.BtnConsultarCNPJ_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(9, 33);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(127, 16);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome/Razão social";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 52);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(120, 22);
            this.TxtNome.TabIndex = 8;
            // 
            // TxtNomeResp
            // 
            this.TxtNomeResp.Location = new System.Drawing.Point(12, 316);
            this.TxtNomeResp.Multiline = true;
            this.TxtNomeResp.Name = "TxtNomeResp";
            this.TxtNomeResp.Size = new System.Drawing.Size(150, 20);
            this.TxtNomeResp.TabIndex = 18;
            // 
            // MtxtTelefone
            // 
            this.MtxtTelefone.Location = new System.Drawing.Point(310, 52);
            this.MtxtTelefone.Mask = "(00)000-000000";
            this.MtxtTelefone.Name = "MtxtTelefone";
            this.MtxtTelefone.Size = new System.Drawing.Size(121, 22);
            this.MtxtTelefone.TabIndex = 22;
            // 
            // LblNomeResp
            // 
            this.LblNomeResp.AutoSize = true;
            this.LblNomeResp.Location = new System.Drawing.Point(9, 297);
            this.LblNomeResp.Name = "LblNomeResp";
            this.LblNomeResp.Size = new System.Drawing.Size(147, 16);
            this.LblNomeResp.TabIndex = 12;
            this.LblNomeResp.Text = "Nome do Responsavel";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(310, 107);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(137, 22);
            this.TxtEmail.TabIndex = 17;
            // 
            // LblCNPJ
            // 
            this.LblCNPJ.AutoSize = true;
            this.LblCNPJ.Location = new System.Drawing.Point(42, 88);
            this.LblCNPJ.Name = "LblCNPJ";
            this.LblCNPJ.Size = new System.Drawing.Size(42, 16);
            this.LblCNPJ.TabIndex = 1;
            this.LblCNPJ.Text = "CNPJ";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(359, 88);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(44, 16);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Email ";
            // 
            // MtxtCEP
            // 
            this.MtxtCEP.Location = new System.Drawing.Point(331, 206);
            this.MtxtCEP.Mask = "0000-000";
            this.MtxtCEP.Name = "MtxtCEP";
            this.MtxtCEP.Size = new System.Drawing.Size(72, 22);
            this.MtxtCEP.TabIndex = 21;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(326, 167);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(100, 22);
            this.TxtCidade.TabIndex = 19;
            // 
            // MtxtNumero
            // 
            this.MtxtNumero.Location = new System.Drawing.Point(331, 249);
            this.MtxtNumero.Mask = "00000";
            this.MtxtNumero.Name = "MtxtNumero";
            this.MtxtNumero.Size = new System.Drawing.Size(40, 22);
            this.MtxtNumero.TabIndex = 20;
            this.MtxtNumero.ValidatingType = typeof(int);
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(339, 33);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(64, 16);
            this.LblTelefone.TabIndex = 11;
            this.LblTelefone.Text = "Telefone ";
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(71, 249);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(100, 22);
            this.TxtEstado.TabIndex = 16;
            // 
            // LblEnderco
            // 
            this.LblEnderco.AutoSize = true;
            this.LblEnderco.Location = new System.Drawing.Point(4, 137);
            this.LblEnderco.Name = "LblEnderco";
            this.LblEnderco.Size = new System.Drawing.Size(128, 16);
            this.LblEnderco.TabIndex = 2;
            this.LblEnderco.Text = "Endereço completo:";
            // 
            // LblRua
            // 
            this.LblRua.AutoSize = true;
            this.LblRua.Location = new System.Drawing.Point(9, 173);
            this.LblRua.Name = "LblRua";
            this.LblRua.Size = new System.Drawing.Size(39, 16);
            this.LblRua.TabIndex = 3;
            this.LblRua.Text = "Rua -";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(267, 209);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(41, 16);
            this.LblCEP.TabIndex = 10;
            this.LblCEP.Text = "CEP -";
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(71, 167);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(100, 22);
            this.TxtRua.TabIndex = 14;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(71, 206);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(100, 22);
            this.TxtBairro.TabIndex = 15;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(246, 255);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(62, 16);
            this.LblNumero.TabIndex = 5;
            this.LblNumero.Text = "Numero -";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(8, 255);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(57, 16);
            this.LblEstado.TabIndex = 9;
            this.LblEstado.Text = "Estado -";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(9, 212);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(50, 16);
            this.LblBairro.TabIndex = 6;
            this.LblBairro.Text = "Bairro -";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(250, 173);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(58, 16);
            this.LblCidade.TabIndex = 4;
            this.LblCidade.Text = "Cidade -";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(420, 397);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(109, 49);
            this.BtnSair.TabIndex = 27;
            this.BtnSair.Text = "Cancelar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // MtxtCnpj
            // 
            this.MtxtCnpj.Location = new System.Drawing.Point(7, 109);
            this.MtxtCnpj.Mask = "00,000,000/0000-00";
            this.MtxtCnpj.Name = "MtxtCnpj";
            this.MtxtCnpj.Size = new System.Drawing.Size(125, 22);
            this.MtxtCnpj.TabIndex = 31;
            // 
            // FrmCadastroF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 458);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GpFormularioCad);
            this.Controls.Add(this.BtnCadastro);
            this.Name = "FrmCadastroF";
            this.Text = "Cadastro";
            this.GpFormularioCad.ResumeLayout(false);
            this.GpFormularioCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.GroupBox GpFormularioCad;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNomeResp;
        private System.Windows.Forms.MaskedTextBox MtxtTelefone;
        private System.Windows.Forms.Label LblNomeResp;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblCNPJ;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.MaskedTextBox MtxtCEP;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.MaskedTextBox MtxtNumero;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label LblEnderco;
        private System.Windows.Forms.Label LblRua;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnConsultarCNPJ;
        private System.Windows.Forms.MaskedTextBox MtxtCnpj;
    }
}

