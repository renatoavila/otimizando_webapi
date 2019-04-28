using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; } 
        public long Pontos { get; set; }
        public long SaldoPontos { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCastro { get; set; }
        public List<Pessoa> Filhos { get; set; }
    }
}