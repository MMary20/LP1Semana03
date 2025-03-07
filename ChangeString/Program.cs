using System;

class ChangeString
{
    static void Main()
    {
        Console.Write("String: ");
        string texto = Console.ReadLine();
        
        Console.Write("Caráter: ");
        char carParaSubstituir = Console.ReadLine()[0]; 

        string resultado = texto.Replace(carParaSubstituir, 'x');

        Console.WriteLine("Será impresso: " + resultado);
    }
}

