using CSharpChallenge.Domain.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CSharpChallenge.Domain.Services
{
    public class InputListFilterWithLinqOperator : IInputListFilter
    {
        public List<int> GetEvenNumbers(List<int> input)
        {
            return input.Where(x => IsEvenValue(x)).ToList();
        }

        public bool IsEvenValue(int value)
        {
            return value % 2 == 0;
        }
    }
}