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
            Console.WriteLine("Introduce una frase y el programa contara los espacios");
            String str = "";
            str = Console.ReadLine();
            if (str != null)
            {
                Console.WriteLine("Los espacios de la frase " + str + " son: " + encuentraEspacios(str));

            }

            //Ejercicio3
            
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
            }

            //Ejercicio5
            
            Console.WriteLine("Introduce la base y el exponente para calcular una potencia");
            if (int.TryParse(Console.ReadLine(), out int numeroBase) && int.TryParse(Console.ReadLine(), out int numeroExponente))
            {
                Console.WriteLine("Resultado: " + potencia(numeroBase, numeroExponente));
            }
            Console.WriteLine("Introduce la base y el exponente para calcular una potencia");
            if (int.TryParse(Console.ReadLine(), out int numeroBase2) && int.TryParse(Console.ReadLine(), out int numeroExponente2))
            {
                Console.WriteLine("Resultado: " + potenciaRecursiva(numeroBase2, numeroExponente2));
            }

            //Ejercicio6
            
            int intentos = 3;
            bool retorno = false;
            while (!retorno && intentos != 0)
            {
                Console.WriteLine("Introduce el usuario y la contraseña");
                Console.WriteLine(">>");
                String user = Console.ReadLine();
                Console.WriteLine(">>");
                String contra = Console.ReadLine();

                if (login(user, contra))
                {
                    Console.WriteLine("FELICIDADES!!! Contraseña Correcta!!!!!");
                    break;
                }
                else
                {
                    intentos--;
                }

                   
            }
            
            if (intentos == 0)
            {
                Console.WriteLine("Lo siento número máximo de intentos alcanzado");
            }

            

            //Ejercicio7
            
            Console.WriteLine("Introduce dos números para ver si uno es multiplo de otro");
            String numeroAString = Console.ReadLine();
            String numeroBString = Console.ReadLine();
            if (numeroAString != null && numeroBString != null)
            {
                if (int.TryParse(numeroAString, out int numeroA) && int.TryParse(numeroBString, out int numeroB))
                {
                    if (esMultiplo(numeroA, numeroB))
                    {
                        Console.WriteLine("Los números son multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Los números no son multiplos");
                    }
                }
            }
            
            //Ejercicio8
            Console.WriteLine("Introduce un número");
            String numeroString = Console.ReadLine();
            if (numeroString != null)
            {
                if (int.TryParse(numeroString, out int numero))
                {
                    Console.WriteLine("La suma de los digitos de: " + numero + " es: " + sumaLasCifrasDeUnNumero(numero));
                    Console.WriteLine("La suma de los digitos de: " + numero + " es: " + sumaCifras(numero));
                }
            }
            


            //Ejercicio9
            Console.WriteLine("Este programa dice el número menor de un array  ;)");
            Random random = new Random();

            int[] array = haceArray();

            foreach (var item in array)
            {
            Console.WriteLine(item);
                
            }

            Console.WriteLine("El menor es: " + esMenor(array));

            

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

        
        
        static Boolean login(String user, String psswd)
        {
            String usuario = "usuario2DAM";
            String contrasena = "pass2DAM";


            if (user.Equals(usuario) && psswd.Equals(contrasena))
            {
                Console.WriteLine("Contraseña y Usuario correcto");
                return true;
            }
            else
            {
                Console.WriteLine("Contraseña o Usuario incorrecto, intentalo de nuevo");
            }


            return false;      
        }

        //Ejercicio 7
        static Boolean esMultiplo(int a, int b)
        {
            if (a % b == 0 || b % a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ejercicio8

        static int sumaLasCifrasDeUnNumero(int n)
        {
            String nString = n.ToString();
            int suma = 0;
            for (int i = 0; i <= nString.Length; i++)
            {
            nString = n.ToString();
            
                String subString = nString.Substring(nString.Length-1);
                if (int.TryParse(subString, out int digito))
                {
                    suma += digito;
                }
                n = n / 10;
            }

            return suma;
            
        }

        static int sumaCifras(int n)
        {
            int suma = 0;
            while (n != 0)
            {
                suma += (n % 10);
                n /= 10;
            }
            return suma;
        }

        //Ejercicio9
        static int esMenor(int[] deNumeros)
        {
            int menor = int.MaxValue;
            foreach (var numero in deNumeros)
            {
                if (numero < menor)
                {
                    menor = numero;
                }
            }
            return menor;
        }

        static int[] haceArray()
        {
            int[] array = new int[9];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }
            return array;

        }

    }
    
}