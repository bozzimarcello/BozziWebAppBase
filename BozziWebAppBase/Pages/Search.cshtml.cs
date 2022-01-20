using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BozziWebAppBase.Models;

namespace BozziWebAppBase.Pages
{
    public class SearchModel : PageModel
    {
        public string Q { get; set; }
        public List<Risultato> Results { get; set; }
        public void OnGet(string q)
        {
            Q = q;
            Results = RisultatiDAL.GetAllRisultati(q);
        }
    }
}
