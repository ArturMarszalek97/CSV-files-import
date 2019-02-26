using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public int indeks;
        public int wiersz;

        public Osoba(string imie, string nazwisko, int indeks, int wiersz)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.indeks = indeks;
            this.wiersz = wiersz;
        }

        public Osoba()
        {

        }
    }
}