using CSharpChallenge.Domain.Contracts;
using System.Collections.Generic;

namespace CSharpChallenge.Domain.Services
{
    public class InputListFilterWithLoopIterate : IInputListFilter
    {
        public List<int> GetEvenNumbers(List<int> input)
        {
            List<int> result = new List<int>();
            foreach (var item in input)
            {
                if (IsEvenValue(item))
                    result.Add(item);
            }

            return result;
        }

        public bool IsEvenValue(int value)
        {
            return value % 2 == 0;
        }
    }
}