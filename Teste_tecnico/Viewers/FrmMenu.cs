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
using Teste_tecnico.Controllers;
using Teste_tecnico.Controllers.Factory;
using Teste_tecnico.Models;
using Teste_tecnico.Models.Factory;

namespace Teste_tecnico.Viewers
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void BtnAdicionarCad_Click(object sender, EventArgs e)
        {
            var Frm = new FrmCadastroF();
            Frm.ShowDialog();
            CarregarFornecedores();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtGridList.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = DtGridList.SelectedRows[0];


                Fornecedor fornecedorSelecionado = (Fornecedor)selectedRow.DataBoundItem;


                FrmEdita frmEdita = new FrmEdita(fornecedorSelecionado);


                frmEdita.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para editar.");
            }

            CarregarFornecedores();
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (DtGridList.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = DtGridList.SelectedRows[0];

               
                Fornecedor fornecedorSelecionado = (Fornecedor)selectedRow.DataBoundItem;

               
                var confirmDelete = MessageBox.Show($"Você tem certeza que deseja excluir o fornecedor {fornecedorSelecionado.Nome}?",
                                                    "Confirmar Exclusão",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    
                    ManipulaInfoBD manipulador = new ManipulaFornecedorBD();

                  
                    bool sucesso = manipulador.Remover(fornecedorSelecionado) > 0;

                    if (sucesso)
                    {
                        
                        fornecedoresList.Remove(fornecedorSelecionado);

                        MessageBox.Show("Fornecedor excluído com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o fornecedor.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para excluir.");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
           var confirma = MessageBox.Show("Você deseja sair?",
                "confirmar saida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private BindingList<Fornecedor> fornecedoresList = new BindingList<Fornecedor>();
        private void CarregarFornecedores()
        {
            
            ManipulaInfoBD manipulador = new ManipulaFornecedorBD(); 

            
            List<Fornecedor> fornecedoresDoBanco = manipulador.ListaFornecedor();

            
            fornecedoresList.Clear();
            foreach (var fornecedor in fornecedoresDoBanco)
            {
                fornecedoresList.Add(fornecedor);
            }

            
            DtGridList.DataSource = fornecedoresList;
        }

    }
}


    


