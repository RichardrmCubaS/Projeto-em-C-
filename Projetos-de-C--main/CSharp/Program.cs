using Enum;
using Interface;
using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            
            Pessoa person = new Pessoa();

            person.Nome = "Ricardo";
            person.Estado = "Ba";
            person.Idade = 51;

            var person2 = new Pessoa();

            person2.Nome = "Helen";
            person2.Estado = "Mg";
            person2.Idade = 43;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.Dono = "Ricardo";
            animal.Especie = "Cachorro";

            var classe1 = new Primeiro.Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine("Hello World!");
        }
    }
}
