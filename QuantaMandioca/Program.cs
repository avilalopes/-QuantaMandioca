using System;
class Desafio {
    static void Main() 
    {
        Console.WriteLine("Quandidade de porções de Chico:");
        int chico = 300 * Int32.Parse(Console.ReadLine());
        Console.WriteLine("Quandidade de porções de Bento:");
        int bento = 1500 * Int32.Parse(Console.ReadLine());
        Console.WriteLine("Quandidade de porções de Bernardo:");
        int bernardo = 600 * Int32.Parse(Console.ReadLine());
        Console.WriteLine("Quandidade de porções de Marina:");
        int marina = 1000 * Int32.Parse(Console.ReadLine());
        Console.WriteLine("Quandidade de porções de Iara:");
        int iara = 150 * Int32.Parse(Console.ReadLine());

        int marlene = 225;
        int total = chico + bento + bernardo + marina + iara + marlene; // Digite aqui o calculo total
        Console.WriteLine(total);
    }
}
