/*
*
*@Author André Filipe
*/
namespace validarData_Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "01/01/2000";
            validaDataNascimento(data);
        }
    


        protected static bool validaDataNascimento(string data)
        {
            DateTime result;
            if (DateTime.TryParse(data, out result))
            {
                if (DateTime.Now.Year - result.Year <= 150)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}