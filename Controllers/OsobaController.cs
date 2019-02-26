using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;
using WebApplication1.Models;
using WebApplication1.ViewModels.Osoby;

namespace WebApplication1.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba
        public ActionResult Index()
        {
            List<Osoba> lista = new List<Osoba>();
            int licz = 1;

            string sciezka = ConfigurationManager.AppSettings["CSV"].ToString();
            StreamReader sr = new StreamReader(sciezka);

            while(!sr.EndOfStream)
            {
                var wiersz = sr.ReadLine();
                string[] podziel = wiersz.Split(',');

                Osoba nowa = new Osoba(podziel[0], podziel[1], Convert.ToInt32(podziel[2]), licz);
                licz++;
                lista.Add(nowa);
            }

            OsobaVM osoba = new OsobaVM();
            osoba.dane = lista;

            
            
            return View(osoba);
        }
    }
}