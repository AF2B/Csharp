/*
*
*@Author: André Filipe
*
*/
using System;
namespace ValidarCPF_CNPJ
{
    class Program
    {
        static void Main(string[] Args)
        {
            string cpf_cnpj = "0";
            // string cpf_cnpj = ""; CPF
            // string cpf_cnpj = ""; CNPJ
            // Console.WriteLine("Digite o CPF ou CNPJ: ");
            // int cpf_cnpj = int.Parse(Console.ReadLine());

            if(cpf_cnpj.Length == 11)
            {
                validaCPF(cpf_cnpj);
            }else if(cpf_cnpj.Length == 14)
            {
                validaCNPJ(cpf_cnpj);
            }
            else if(cpf_cnpj == null)
            {
                Console.WriteLine("That's camp is empty.");
            }
        }

        //Valida CPF 
        /*
        @param type string
        * Return TRUE if CPF is valid
        * Return FALSE if CPF is invalid
        */
        protected static bool validaCPF(string cpf_cnpj)
        {
            if(cpf_cnpj.Length != 11)
            {
                return false;
            }

            int[] pesos1 = new int[9] {10, 9, 8, 7, 6, 5, 4, 3, 2};
		    int[] pesos2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            int soma = 0;
            int resto;
            int digitoVerificador1;
            int digitoVerificador2;

            //Primeiro digito verificador.
            cpf_cnpj = cpf_cnpj.Trim();
            cpf_cnpj = cpf_cnpj.Replace(".", "").Replace("-", "");
            string subCpf = cpf_cnpj.Substring(0, 9);

            for(int i = 0; i < 9; i++)
            {
                soma += int.Parse(subCpf[i].ToString()) * pesos1[i];
            }

            resto = soma % 11;

            if(resto >= 2)
            {
                digitoVerificador1 = 11 - resto;
            }else if(resto < 2)
            {
                digitoVerificador1 = 0;
            }
            else
            {
                throw new Exception("Erro");
            }

            //Segundo digito verificador.
            subCpf = cpf_cnpj.Substring(0, 10);
            soma = 0;

            for(int i = 0; i < 10; i++)
            {
                soma += int.Parse(subCpf[i].ToString()) * pesos2[i];
            }

            resto = soma % 11;

            if(resto >= 2)
            {
                digitoVerificador2 = 11 - resto;
            }
            else if(resto < 2)
            {
                digitoVerificador2 = 0;
            }
            else
            {
                throw new Exception("Erro");
            }

            if(digitoVerificador1 == int.Parse(cpf_cnpj[9].ToString()) && digitoVerificador2 == int.Parse(cpf_cnpj[10].ToString()))
            {
                Console.WriteLine("CPF Válido");
                return true;
            }
            else
            {
                Console.WriteLine("CPF Inválido");
                return false;
            }
        }

        //Valida CNPJ 
        /*
        @param type string
        * Return TRUE if CNPJ is valid
        * Return FALSE if CNPJ is invalid
        */
        protected static bool validaCNPJ(string cpf_cnpj)
        {
            int[] pesos1 = new int[12] {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};
            int[] pesos2 = new int[13] {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};

            int soma = 0;
            int resto;
            int digitoVerificador1;
            int digitoVerificador2;

            //Primeiro digito verificador.
            cpf_cnpj = cpf_cnpj.Trim();
            cpf_cnpj = cpf_cnpj.Replace(".", "").Replace("-", "");
            string subCnpj = cpf_cnpj.Substring(0, 12);

            for(int i = 0; i < 12; i++)
            {
                soma += int.Parse(subCnpj[i].ToString()) * pesos1[i];
            }

            resto = soma % 11;

            if(resto >= 2)
            {
                digitoVerificador1 = 11 - resto;
            }
            else if(resto < 2)
            {
                digitoVerificador1 = 0;
            }
            else
            {
                throw new Exception("Erro");
            }

            //Segundo digito verificador.
            subCnpj = cpf_cnpj.Substring(0, 13);
            soma = 0;

            for(int i = 0; i < 13; i++)
            {
                soma += int.Parse(subCnpj[i].ToString()) * pesos2[i];
            }

            resto = soma % 11;

            if(resto >= 2)
            {
                digitoVerificador2 = 11 - resto;
            }
            else if(resto < 2)
            {
                digitoVerificador2 = 0;
            }
            else
            {
                throw new Exception("Erro");
            }
            
            if(digitoVerificador1 == int.Parse(cpf_cnpj[12].ToString()) && digitoVerificador2 == int.Parse(cpf_cnpj[13].ToString()))
            {
                Console.WriteLine("CNPJ Válido");
                return true;
            }
            else
            {
                Console.WriteLine("CNPJ Inválido");
                return false;
            }
        }
    }
}