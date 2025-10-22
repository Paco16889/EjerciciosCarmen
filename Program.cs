// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata;

// Definición del espacio de nombres (namespace)
namespace EjerciciosCarmen
{
    // Definición de la clase principal
    class Program
    {
        // Método estático Main: punto de entrada de la aplicación
        static void Main(string[] args)
        {
            // Código principal que se ejecuta al iniciar el programa

            //Ejercicio2
            /*Console.WriteLine("Introduce una frase y el programa contara los espacios");
            String str = "";
            str = Console.ReadLine();
            if (str != null)
            {
                Console.WriteLine("Los espacios de la frase " + str + " son: " + encuentraEspacios(str));

            }*/

            //Ejercicio3
            /*
            Console.WriteLine("Introduce un número y el programa te dirá si es primo o no");
            String nString = Console.ReadLine();
            if (int.TryParse(nString, out int n))
            {
                if (esPrimo(n))
                {
                    Console.WriteLine("El numero " + n + " es Primo.");
                }
                else
                {
                    Console.WriteLine("El número " + n + " no es Primo");
                }
            }*/

            //Ejercicio5
            /*
            Console.WriteLine("Introduce la base y el exponente para calcular una potencia");
            if (int.TryParse(Console.ReadLine(), out int numeroBase) && int.TryParse(Console.ReadLine(), out int numeroExponente))
            {
                Console.WriteLine("Resultado: " + potencia(numeroBase, numeroExponente));
            }
            Console.WriteLine("Introduce la base y el exponente para calcular una potencia");
            if (int.TryParse(Console.ReadLine(), out int numeroBase2) && int.TryParse(Console.ReadLine(), out int numeroExponente2))
            {
                Console.WriteLine("Resultado: " + potenciaRecursiva(numeroBase2, numeroExponente2));
            }*/

            //Ejercicio6
            Console.WriteLine("Introduce el usuario y la contraseña");
            Console.WriteLine(">>");
            String user = Console.ReadLine();
            Console.WriteLine(">>");
            String contra = Console.ReadLine();

            if (login(user, contra))
            {
            Console.WriteLine("FELICIDADES!!! Contraseña Correcta!!!!!");
                
            }


             
        }
        //Ejercicio2
        static int encuentraEspacios(String str)
        {
            int contadorEspacios = 0;
            char espacio = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(espacio))
                {
                    contadorEspacios++;
                }
            }

            return contadorEspacios;
        }

        //Ejercicio4
        static Boolean esPrimo(int n)
        {

            if (n < 2 || n % 2 == 0)
                return false;

            if (n == 2)
                return true;


            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;

            }

            return true;
        }
        //Ejercicio 5
        static int potencia(int numBase, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= numBase;
            }

            return resultado;
        }

        static int potenciaRecursiva(int numBase, int exponente)
        {


            return potenciaRecursiva(numBase, exponente);
        }
        
        //Ejercicio 6


        static Boolean pideLogin(String user, String contra)
        {
            
        }
        static Boolean login(String user, String psswd)
        {
            String usuario = "usuario2DAM";
            String contrasena = "pass2DAM";
            bool retorno = false;
            int intentos = 3;

            while (!retorno && intentos != 0)
            {
                if (user.Equals(usuario) && psswd.Equals(contrasena))
                    retorno =   true;

                intentos--;
            }
            return retorno;      
        }

    }
    
}