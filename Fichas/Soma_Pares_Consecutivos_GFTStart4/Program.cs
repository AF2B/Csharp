/**
 *
 * @author André Filipe
 */
using System;

namespace Soma_Pares_Consecutivos_GFTStart4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
        	while (a != 0)
        	{
        	    a = int.Parse(Console.ReadLine());
        	    
        	    int i = a;
        	    int count = 0;
        	    int sum = 0;
        	    
        	    while(a != 0)
        	    {
        	    	i += 1;
        	    	
        	    	if (i % 2 == 0)
        	    	{
        	    		sum += i;
        	    		count += 1;
        	    	}
        	  
        	    	if (a % 2 == 0 && count == 4)
        	    	{
        	    		Console.WriteLine(sum += a);
        	    		break;
        	    	}
        	    	
        	    	if(a % 2 != 0 && count == 5)
        	    	{
        	    		Console.WriteLine(sum);
        	    		break;
        	    	}
        	    }
          	}
        }
    }
}