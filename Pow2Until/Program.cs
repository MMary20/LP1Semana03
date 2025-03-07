using System;

class Pow2Until
{
    static void Main(string[] args)
    {
        PowersOf2Until5();
        PowersOf2Until5();
    }
    private static void PowersOf2Until5()
    {
        int numero = 1;

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(numero);
            numero *= 2;  
        }
    }
}


