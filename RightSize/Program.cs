using System;

class RightSize
{
    static void Main(string[] entradas)
    {
        foreach (string entrada in entradas)
        {
            if (entrada.Length >= 8)
            {
                Console.WriteLine("[EARLY STOP]");
                return;
            }
            if (entrada.Length > 3)
            {
                Console.WriteLine(entrada);
            }
        }
    }
}

