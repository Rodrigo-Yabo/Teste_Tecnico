using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_tecnico.Controllers.Factory;
using Teste_tecnico.Models;

namespace Teste_tecnico.Viewers
{
    public partial class FrmEdita : Form 
    {

        private Fornecedor fornecedorSelecionado;
      
        public FrmEdita(Fornecedor fornecedor)
        {
            InitializeComponent();
            fornecedorSelecionado = fornecedor;
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            if(fornecedorSelecionado != null)
            {
                // Preenche os campos com os dados do fornecedor selecionado
                TxtNome.Text = fornecedorSelecionado.Nome;
                TxtCNPJ.Text = fornecedorSelecionado.CNPJ;
                TxtEmail.Text = fornecedorSelecionado.Email;
                MtxtTelefone.Text = fornecedorSelecionado.Telefone;
                TxtNomeResp.Text = fornecedorSelecionado.NomeResponsavel;
                TxtRua.Text = fornecedorSelecionado.Rua;
                TxtCidade.Text = fornecedorSelecionado.Cidade;
                TxtEstado.Text = fornecedorSelecionado.Estado;
                TxtBairro.Text = fornecedorSelecionado.Bairro;
                MtxtNumero.Text = fornecedorSelecionado.Numero.ToString();
                MtxtCEP.Text = fornecedorSelecionado.Cep;
            }
                
        }

        private bool ValidaCampos()
        {
            if (TxtNome.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Nome é obrigatorio");
                return false;
            }
            if (TxtCNPJ.Text.Equals(String.Empty) || TxtCNPJ.Text.Length != 14)
            {
                MessageBox.Show("Informe um CNPJ ou verefique o CNPJ inserido !!");
                return false;
            }
            if (MtxtTelefone.Text.Equals(String.Empty))
            {
                MessageBox.Show("Informe um numero de telefone ou verifique o numero inserido !!");
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

        private void BtnSalvarEdit_Click(object sender, EventArgs e)
        {

            if (ValidaCampos() == true)
            {

                Fornecedor pFornecedor = new Fornecedor()
                {
                    Nome = TxtNome.Text,
                    CNPJ = TxtCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""),
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
                
                
            }
            else
            {
                MessageBox.Show("Verifique os campos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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

    }
}
