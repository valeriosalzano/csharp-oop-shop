﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI

        decimal _Prezzo;

        // PROPRIETA'

        public int Codice { get; private set; } = new Random().Next(0, 999);
        public string Nome { get; set; }
        public string Descrizione { get; set; } = "";
        public decimal Prezzo { 
            get
            {
                return _Prezzo;
            } 
            set
            {
                if (value <= 0)
                    Console.WriteLine("Valore non valido"); //qui andrebbe un'eccezione
                else
                    _Prezzo = value;
            }
        } 
        public float Iva { get; set; }

        // COSTRUTTORI

        public Prodotto(string Nome, decimal Prezzo, float Iva)
        {
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.Iva = Iva;
        }

        public Prodotto(string Nome, string Descrizione, decimal Prezzo, float Iva)
        {
            this.Nome = Nome;
            this.Descrizione = Descrizione;
            this.Prezzo = Prezzo;
            this.Iva = Iva;
        }

        // METODI

        public decimal GetPrezzoFinale()
        {
            return Math.Round(this.Prezzo * (1 + (decimal) this.Iva), 2);
        }

        public string GetNomeCompleto()
        {
            return this.Codice + this.Nome;
        }

        public string GetCodiceConPadLeft()
        {
            string codice = this.Codice.ToString();
            while (codice.Length < 8)
                codice = "0" + codice;
            return codice;
        }

        public void StampaProdotto()
        {
            Console.WriteLine(" ----- Informazioni di base ------ ");
            Console.WriteLine("Nome Completo:" + this.GetNomeCompleto());
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Codice: " + this.Codice);
            Console.WriteLine("CodiceConPadLeft: " + this.GetCodiceConPadLeft());
            if(this.Descrizione != "")
            {
                Console.WriteLine(" ----- Descrizione ------ ");
                Console.WriteLine(this.Descrizione);
            }
            Console.WriteLine(" ----- Costo ------ ");
            Console.WriteLine("Prezzo base: euro " + this.Prezzo);
            Console.WriteLine("Iva: " + this.Iva);
            Console.WriteLine("Prezzo finale: euro " + this.GetPrezzoFinale());
        }
    }
}
