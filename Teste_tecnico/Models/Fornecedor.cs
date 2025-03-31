using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teste_tecnico.Controllers;
using Teste_tecnico.Controllers.Factory;


namespace Teste_tecnico.Models
{
    public class Fornecedor : ManipulaInfoBD
    { 
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NomeResponsavel { get; set; }

        // informaçoes de endereço:
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        
        
    }
   
}
    