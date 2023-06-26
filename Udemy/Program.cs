using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciamos la clase Automovil
            Automovil automovil = new Automovil();
            automovil.color = "rojo";
            automovil.combustible = "diesel";
            Console.WriteLine(" el tipo de combustible es: {0}", automovil.combustible);
         
        }
    }
    //[modificador de acceso] [class] [identificador]
    public class Automovil
    {

        //campos
        public string color, modelo, combustible;
        public byte año, numPuertas;
        public int ccMotor;


        //metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            return acelerar;

        }
        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("frenar");
            return frenar;

        }


        public void velocidades(ref byte velocidadPa) //pasar por referencia
        {
            velocidadPa++;
            Console.WriteLine("cambio de velocidad");
            

        }
        //instancia de una clase

    }
}