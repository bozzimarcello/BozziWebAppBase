using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BozziWebAppBase.Models
{
    public class RisultatiDAL
    {
        public static List<Risultato> GetAllRisultati(string q)
        {

            List<Risultato> lista = new List<Risultato>();

            /*
            lista.Add(new Risultato { Id = 1, Titolo = "Primo", Descrizione = "Primo record" });
            lista.Add(new Risultato { Id = 2, Titolo = "Secondo", Descrizione = "Secondo record" });
            lista.Add(new Risultato { Id = 3, Titolo = "Terzo", Descrizione = "Terzo record" });
            */

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String sql = "SELECT EmployeeID, LastName, FirstName FROM Employees";

                if (q != null)
                {
                    sql += " WHERE LastName LIKE '%" + q + "%'";
                }

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Risultato { Id = reader.GetInt32(0), Nome = reader.GetString(1), Cognome = reader.GetString(2) });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
