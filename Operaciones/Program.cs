using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        /// <summary>
        /// Inicio de Programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //El tipo de datos string se usa para manejar textos
            //El tipo de datos int se usa para manejar números naturales
            //El tipo de datos decimal se usa para manejar números con decimales
            //El tipo de datos DateTime se usa para manejar fechas
            //El tipo de datos bool se usa para manejar true o false 
            //Como declarar una variable 
            //string.Empty == texto vacio
            string nombre = string.Empty;
            //Console.ReadLine(); permite leer lo que escriba el usuario en la consola, devolviendolo en formato texto
            nombre = Console.ReadLine();
            Saludar(nombre);
            Console.ReadKey();
            //Para Convertir de un tipo de datos a otro se usa la Clase Convert
            //int numero = Convert.ToInt32(variable);
            /*
             * En base a esto debe ser capaz de usar los metodos sumar, restar, dividir y multiplicar mostrando 
             * por pantalla la funcion que estas usando 
             * ejemplo Sumar 1+3= 4
            */
        }

        /// <summary>
        /// Funcion que permite saludar
        /// </summary>
        /// <param name="nombre"></param>
        public static void Saludar(string nombre)
        {
            Console.WriteLine("Bienvenido: " + nombre);
        }


        /// <summary>
        /// Metodo que permite sumar 2 números
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="NumeroDos"></param>
        /// <returns>retorna la suma de los 2 numeros</returns>
        public static int Suma(int numeroUno, int NumeroDos)
        {
            return numeroUno + NumeroDos;
        }
        /// <summary>
        /// Metodo que permite restar 2 números
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="NumeroDos"></param>
        /// <returns>retorna la resta de los 2 numeros</returns>
        public static int Resta(int numeroUno, int NumeroDos)
        {
            return numeroUno - NumeroDos;
        }
        /// <summary>
        /// Metodo que permite multiplicar 2 números
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="NumeroDos"></param>
        /// <returns>retorna la multiplicación de los 2 numeros</returns>
        public static int Multiplicacion(int numeroUno, int NumeroDos)
        {
            return numeroUno * NumeroDos;
        }
        /// <summary>
        /// Metodo que permite dividir 2 números
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="NumeroDos"></param>
        /// <returns>retorna la división de los 2 numeros</returns>
        public static decimal Division(int numeroUno, int NumeroDos)
        {
            return numeroUno / NumeroDos;
        }
    }
}
