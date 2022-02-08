namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que calcule a idade média de 5 alunos.
            Console.WriteLine("Digite a idade do 1 aluno: ");
            double idade1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do 2 aluno: ");
            double idade2 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite as idade do 3 aluno: ");
            double idade3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as idade do 4 aluno: ");
            double idade4 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as idade do 5 aluno: ");
            double idade5 = Double.Parse(Console.ReadLine());

            double media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine("A Média da idade entre estes alunos é de: " + media);
        }
    }
}