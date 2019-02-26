using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels.Osoby
{
    public class OsobaVM : Osoba
    {
        public List<Osoba> dane { get; set; }
    }
}