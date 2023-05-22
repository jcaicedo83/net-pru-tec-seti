using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Persona { nombre = "Javier", edad = 40, peso = 75 };

            Console.WriteLine(cliente.CambiaNombre());

            Console.WriteLine(cliente.Calcula());
        }

        public triangulo achatar (triangulo item)
        {
            var _area = item.area();
            item.altura = (float)(item.altura - (item.altura * 0.1));
            item.baseT = _area / item.altura;
            return item;
        }
    }

    class triangulo
    {
        public float baseT, altura;
        public float area()
        {
            return (baseT * altura) / 2;
        }
   }

    class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public decimal peso { get; set; }

        public string CambiaNombre() => $"Hola_{this.nombre}";
        public decimal Calcula() => (this.edad * this.peso);
    }
}
