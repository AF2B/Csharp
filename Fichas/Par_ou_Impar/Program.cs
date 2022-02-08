namespace Par_ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que verifique se um número informado é par ou impar
            Console.WriteLine("Digite um número: ");
            int ParImpar = int.Parse(Console.ReadLine());

            if(ParImpar % 2 == 0)
            {
                Console.WriteLine("Este número é par.");
            }
            else
            {
                Console.WriteLine("Este número é impar.");
            }
        }
    }
}
