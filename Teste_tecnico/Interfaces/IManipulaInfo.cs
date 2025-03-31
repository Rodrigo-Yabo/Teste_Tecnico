using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_tecnico.Models;

namespace Teste_tecnico.Controllers.Factory
{
    public interface IManipulaInfo 
    {
        bool Adicionar(Fornecedor pfornecedo);
        int Remover(Fornecedor pfornecedor);

        List<Fornecedor> ListaFornecedor();
        

    }
}
