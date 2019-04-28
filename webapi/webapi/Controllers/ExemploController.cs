using System.Collections.Generic;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class ExemploController : ApiController
    {
        public List<Pessoa> Get()
        {
            List<Pessoa> lista = new List<Pessoa>();
            Pessoa pessoa;

            for (int i = 0; i < 100; i++)
            {
                pessoa = new Pessoa();
                pessoa.Id = i;
                pessoa.PrimeiroNome = "Pessoa " + i.ToString();
                pessoa.SegundoNome = " Sobrenome";
                pessoa.Filhos = new List<Pessoa>() {
                                                    new Pessoa()
                                                        {
                                                            PrimeiroNome = "Filho ",
                                                            SegundoNome = "da Pessoa " + i.ToString()
                                                        }
                                                    };
                lista.Add(pessoa);
            }

            return lista;
        }



    }
}