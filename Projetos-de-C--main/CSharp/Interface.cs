using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Nome(string Nome);
        void Dono(string Dono);
        void Especie(string Especie);
    }

    class Animal: IAnimal
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;

        }
        void IAnimal.Dono(string dono)
        {
            this.Dono = dono;

        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;

        }
    }

}
