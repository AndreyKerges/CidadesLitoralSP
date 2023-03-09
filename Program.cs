using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nome das cidades do litoral sul de São Paulo:");
        Console.WriteLine();
        string[] cidades = {"Peruíbe", "Itanhaém", "Mongaguá", "Praia Grande", "São Vicente", "Santos", "Guarujá", "Bertioga", "São Sebastião", "Ilhabela", "Caraguatatuba", "Ubatuba"};
        
        foreach(string cidade in cidades)
        {
            Console.WriteLine(cidade);
        }
    }
}
