/**
 *
 * @author André Filipe
 */

namespace Verificar_Se_Maior_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
            int[] idades = new int[10] {24, 25, 18, 16, 14, 13, 40, 55, 36, 50};
            int cont = 0;

            foreach(int idade in idades)
            {
                if(idade >= 18)
                {
                    cont = cont + 1;
                }
            }
                
            Console.WriteLine("A Quantidade de pessoas maiores de idade é de: " + cont + "Pessoas.");
        }
    }
}