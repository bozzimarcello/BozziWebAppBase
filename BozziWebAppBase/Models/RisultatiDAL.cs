using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BozziWebAppBase.Models
{
    public class RisultatiDAL
    {
        public static List<Risultato> GetAllRisultati()
        {

            List<Risultato> lista = new List<Risultato>();

            lista.Add(new Risultato { Id = 1, Titolo = "Primo", Descrizione = "Primo record" });
            lista.Add(new Risultato { Id = 2, Titolo = "Secondo", Descrizione = "Secondo record" });
            lista.Add(new Risultato { Id = 3, Titolo = "Terzo", Descrizione = "Terzo record" });

            return lista;
        }
    }
}
