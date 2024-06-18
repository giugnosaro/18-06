using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_06
{
    internal class Persona
    {
        string nome = "";
        string cognome = "";
        byte eta = 0;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome 
        {
            get { return cognome; }
            set { cognome = value; } 
        }

        public byte Eta
        {
            get { return eta; }
            set { eta = value; } 
        }

        public void NomeCompleted()
        {
            Console.WriteLine("nome " +  nome);
        }
        
        public void NomeCompleted(string cognome)
        {
            Console.WriteLine("cognome " + cognome);
        }

        public void NomeCompleted(byte eta)
        {
            Console.WriteLine("eta " + eta + " anni");
        }

        public void NomeCompleted(string nome,string cognome, byte eta)
        {
            Console.WriteLine("Descrizione "+ nome + " " + cognome + " " + eta);
        }
    }
}
