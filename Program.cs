using System;

namespace ConsolaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "hola";
                
            valor += " mundo";

            string valor2= Resolver(valor);
            
            Console.WriteLine(valor2);                     

        }

         public static string Resolver(string parametro)
        {
            return parametro + " !!";
        }

        public static string Algo()
        {
            return "";
        }
    }   

}
