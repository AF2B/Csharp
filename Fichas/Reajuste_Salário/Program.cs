//Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários 
//de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, 
//reajuste de 30%.
/**
 *
 * @author André Filipe
 */
 namespace Reajuste_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salarios = new int[10]{100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};

            foreach(int salario in salarios)
            {
                if(salario <= 300)
                {
                    Console.WriteLine(salario * 0.50);
                }
                else
                {
                    Console.WriteLine(salario * 0.30);
                }
            }
            Console.WriteLine($"Salários reajustados: {salarios}");
        }
    }
}