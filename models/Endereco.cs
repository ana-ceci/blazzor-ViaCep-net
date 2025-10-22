using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorViaCep.Models
{
    public class endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
         public string bairro { get; set; }
        public string complemento { get; set; }
        public string unidade { get; set; }
        public string Uf { get; set; }
        public string estado { get; set; }
        public string regiao { get; set; }
        public string Localidade { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
        public string cidade { get; set; }
    }
}
