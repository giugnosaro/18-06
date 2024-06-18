using System.Runtime.CompilerServices;

namespace _18_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Persona persona = new Persona();
            persona.Nome = "saro";
            persona.Cognome = "rossi";
            persona.Eta = 137;
            persona.NomeCompleted();
            persona.NomeCompleted(persona.Cognome);
            persona.NomeCompleted(persona.Eta);
            persona.NomeCompleted(persona.Nome , persona.Cognome, persona.Eta);
        }
    }
}
