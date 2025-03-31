using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Teste_tecnico.Interfaces;
using System.Text.Json;


namespace Teste_tecnico.Models.Factory
{
    public class CnpjFabrica : ICnpjFabrica
    {
        public ICnpjFabrica CriaFornecedor()
        {

            return new CnpjFabrica(); 
        }


        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://brasilapi.com.br/api/cnpj/v1/";

        public CnpjFabrica()
        {
            _httpClient = new HttpClient();
        }
        public async Task<CnpjData> ConsultaAsync(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14)
                throw new ArgumentException("CNPJ inválido.");

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");

                
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CnpjData>(json);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Erro na consulta: {ex.Message}");
            }
        }

    }
}

