using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_tecnico.Models.Factory;

namespace Teste_tecnico.Interfaces
{
    public interface ICnpjFabrica
    {
        ICnpjFabrica CriaFornecedor();
        Task<CnpjData> ConsultaAsync(string cnpj);


    }
}
