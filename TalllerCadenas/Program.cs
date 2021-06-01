using System;

namespace TallerCadenas
{
    class Program
    {
        static void Main(string[] args)
        {

            //string cadena_input = "#EJEMPLO:ENTRADA = CAD#E#NA";
            // Entrada de Datos: La Cadena de entrada y el Caracter especial a Evaukuar
            Console.WriteLine("Ingrese la cadena :");
            string cadena_input = Console.ReadLine();
            
            // Inicializa Variable en False Para Asegurar que el caracter especial Ingresado por Teclado esté dentro de la Cadena de entrada
            int ok = 0;
            string char_especial = "";
            char[] array_cad = new char[cadena_input.Length];
            //Llenar Array con la cadena de entrada
            for (int k=0; k < cadena_input.Length; k++)
            {
                array_cad[k] = Convert.ToChar(cadena_input.Substring(k, 1));
            }

            while (ok==0)
            {
                Console.WriteLine("Ingrese el Cáracter Especial:");
                char_especial = Console.ReadLine();
                for (int f = 0; f<cadena_input.Length; f++)
                {
                    //Console.WriteLine("Indice f={0} Array= {1}", f, array_cad[f]);
                    if (array_cad[f]==(Convert.ToChar(char_especial)))
                    {
                        ok = 1;
                        //Console.WriteLine("Caracter {0} Encontrado en la Posicion {1}",char_especial,f);
                    }
                }
            } 
            // Invoca la Funcion y retorna la cadena de Salida  
            string cadena_output = Buscar_Cadena(cadena_input, Convert.ToString(char_especial));

            Console.WriteLine("Cadena Salida: {0}", cadena_output);
        }

        private static string Buscar_Cadena(string cadena, string char_busqueda)
        {
            string cadena_salida = "";
            string char_salida = "";
            int cont = 0;
            char[] array_cadena = new char[cadena.Length];
            //Llenar Array con la cadena de entrada
            for (int k = 0; k < cadena.Length; k++)
            {
                array_cadena[k] = Convert.ToChar(cadena.Substring(k, 1));
            }

            for (int i= 0;i< cadena.Length; i++)
            {
                if (array_cadena[i]== Convert.ToChar(char_busqueda))
                {
                    Console.WriteLine("El Caracter {0} está en la Posición {1} de la Cadena de entrada", char_busqueda, i);
                    cont = cont + 1;
                    char_salida = "";
                }
                else
                {
                    char_salida = Convert.ToString(array_cadena[i]);
                }
                cadena_salida = cadena_salida + char_salida;
            }
            Console.WriteLine("El Caracter {0} Aparece {1} veces en la cadena de entrada", char_busqueda, cont);
            return cadena_salida;
        }
    }
}
