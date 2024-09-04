using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la operación que deseas hacer '+' '-' '*' '/' ");
            string ope = Console.ReadLine();

            var result = 0;
            var Suma = new Program();
            

            switch (ope)
            {
                case "+":
                    result = Suma.Suma(num1,num2);
                    Console.WriteLine("El resultado es: "+  result);
                    break;
                case "-":
                    result = Suma.Resta(num1, num2);
                    Console.WriteLine("El resultado es: " + result);
                    break;
                case "*":
                    result = Suma.Multiplicacion(num1, num2);
                    Console.WriteLine("El resultado es: " + result);
                    break;
                case "/":
                    result = Suma.Divicion(num1, num2);
                    Console.WriteLine("El resultado es: " + result);
                    break;
                default: Console.WriteLine("Por favor intentelo de nuevo");
                    break;
            }
        }
        public int Suma(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Resta(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Multiplicacion(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Divicion(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}