using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_tecnico.Controllers;
using Teste_tecnico.Controllers.Factory;
using Teste_tecnico.Interfaces;
using Teste_tecnico.Models;
using Teste_tecnico.Models.Factory;

namespace Teste_tecnico
{
    public partial class FrmCadastroF : Form
    {
        public FrmCadastroF()
        {
            InitializeComponent();

        }
        private bool ValidaCampos()
        {
            if (TxtNome.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Nome é obrigatorio");
                return false;
            }
            if (MtxtCnpj.Text.Equals(String.Empty) ||   MtxtCnpj.Text.Length != 14)
            {
                MessageBox.Show("Informe um CNPJ ou verefique o CNPJ inserido !!");
                return false;
            }
            if (MtxtTelefone.Text.Equals(String.Empty))
            {
                MessageBox.Show("Telefone invalido !!");
                return false;

            }
            if (TxtEmail.Text.Equals(String.Empty))
            {
                MessageBox.Show("Informe um endereço de Emaill !!");
                return false;
            }
            if (TxtBairro.Text.Equals(String.Empty))
            {
                return false;
            }
            if (TxtCidade.Text.Equals(String.Empty))
            {
                MessageBox.Show("É obrigatorio informar uma Cidade !!");
                return false;
            }
            if (TxtEstado.Text.Equals(String.Empty))
            {
                MessageBox.Show("É obrigatorio informar um Estado !!");
                return false;
            }
            if (MtxtCEP.Text.Equals(String.Empty) || MtxtCEP.TextLength != 8)
            {
                MessageBox.Show("Informe um CEP ou verifique o CEP inserido !!");
                return false;

            }
            if (TxtNomeResp.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nome do responsavel é obrigatorio");
                return false;
            }
            else
            {
                MessageBox.Show(" Cadstro realizado com sucesso !!");
                return true;
            }


        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {

            if (ValidaCampos() == true)
            {
                Fornecedor pFornecedor = new Fornecedor()
                {
                    Nome = TxtNome.Text,
                    CNPJ = MtxtCnpj.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
                    Email = TxtEmail.Text,
                    Telefone = MtxtTelefone.Text,
                    NomeResponsavel = TxtNomeResp.Text,
                    Rua = TxtRua.Text,
                    Cidade = TxtCidade.Text,
                    Estado = TxtEstado.Text,
                    Numero = MtxtNumero.Text.ToString(),
                    Bairro = TxtBairro.Text,
                    Cep = MtxtCEP.Text.Replace("-", "").Trim()
                };

                IManipulaInfo Manipulador = new Fornecedor();
                var aux = Manipulador.Adicionar(pFornecedor);
                this.Close();
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var Confirma = MessageBox.Show(
               "Todas as alterações feitas serão perdidas. Deseja continuar?",
               "Cancelar Edição",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (Confirma == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

                MessageBox.Show("Continue a edição.", "Edição Continuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void BtnConsultarCNPJ_Click(object sender, EventArgs e)
        {
            string cnpj = MtxtCnpj.Text.Trim();

            if (!ValidarFormatoCnpj(cnpj)) 
            {
                MessageBox.Show("Formato de CNPJ inválido!");
                return;
            }
            if (!ValidarDigitosCnpj(cnpj))
            {
                MessageBox.Show("Digitos verificadores invalidos!");
                return;
            }

            try
            {
                ICnpjFabrica provider = new CnpjFabrica();
                CnpjData dados = await provider.ConsultaAsync(cnpj);

                if (dados == null)
                {
                    MessageBox.Show("CNPJ não encontrado na base de dados.");
                    return;
                }

                PreencherFormulario(dados); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

            void PreencherFormulario(CnpjData dados)
            {
                
                TxtNome.Text = dados.RazaoSocial;
               

                
                TxtRua.Text = dados.Logradouro;
                MtxtNumero.Text = dados.Numero;
                TxtBairro.Text = dados.Bairro;
                MtxtCEP.Text = dados.Cep;
                TxtCidade.Text = dados.Municipio;
                TxtEstado.Text = dados.Uf;

                
                MtxtTelefone.Text = dados.Telefone ?? "";
                TxtEmail.Text = dados.Email ?? "";
                TxtNomeResp.Text = dados.NomeResponsavel ?? "";
            }


        }
        private bool ValidarFormatoCnpj(string cnpj)
        {
           
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            
            return cnpj.Length == 14 && !cnpj.All(c => c == cnpj[0]);
        }
        public static bool ValidarDigitosCnpj(string cnpj)
        {
            int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("/", "").Replace("-", "");
            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }




    }
}
           
         






        
           
   


        
   



    





