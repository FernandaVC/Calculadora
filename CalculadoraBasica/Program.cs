using System;

namespace CalculadoraBasica
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string signo;
            Console.WriteLine("Inserte los numeros!");
            Console.WriteLine("Inserte numero1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte numero2");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte una operación");
            signo = Console.ReadLine();
            switch(signo)
            {
                case "+":
                    {
                        resultado = numero1 + numero2;
                        Console.WriteLine("Su resultado de su suma es: " + resultado);
                        break;
                    }
                case "-":
                    {
                        resultado = numero1 - numero2;
                        Console.WriteLine("Su resultado de su resta es: " + resultado);
                        break;
                    }
                case "*":
                    {
                        resultado = numero1 * numero2;
                        Console.WriteLine("Su resultado de su multiplicación es: " + resultado);
                        break;
                    }
                case "/":
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("Su resultado de su división es: " + resultado);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("El signo no es válido");
                        break;
                    }
            }
        }
    }
}
