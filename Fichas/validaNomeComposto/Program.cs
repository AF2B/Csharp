/*
*
*@Author André Filipe
* Precisa alterar o regex.
*/
using System;
using System.Text.RegularExpressions;

namespace validarNomeComposto
{
    class Program
    {
        static void Main(string[] args)
        {
            string meuNome = "André Filipe";
            validarNome(meuNome);
        }

        protected static bool validarNome(string nome)
        {
            Regex regex = new Regex(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$");
            Match match = regex.Match(nome);
            if (match.Success)
            {
                Console.WriteLine("Nome válido");
                return true;
            }
            else
            {
                Console.WriteLine("Nome inválido");
                return false;
            }
        }
    }
}