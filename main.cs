using CSharpChallenge.Domain.Services;
using System;
using System.Collections.Generic;

class Program {
    private static readonly List<int> _inputList = new List<int>() 
    { 
      1, 2, 3, 4, 5, 6, 7, 8, 9, 10 
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Original input list: ");
        Console.WriteLine(ListToString(_inputList));

        var iterateResultList = new InputListFilterWithLinqOperator().GetEvenNumbers(_inputList);
        Console.WriteLine("Even numbers using loop: ");
        Console.WriteLine(ListToString(iterateResultList));

        var linqResultList = new InputListFilterWithLinqOperator().GetEvenNumbers(_inputList);
        Console.WriteLine("Even numbers using linq operator: ");
        Console.WriteLine(ListToString(iterateResultList));

        Console.ReadKey();
    }

    static string ListToString(List<int> list)
    {
        char delimiterChar = ';';
        return string.Join(delimiterChar, list.ToArray());
    }
}