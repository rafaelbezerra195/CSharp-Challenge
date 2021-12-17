using System.Collections.Generic;

namespace CSharpChallenge.Domain.Contracts
{
    public interface IInputListFilter
    {
        public List<int> GetEvenNumbers(List<int> input);

        public bool IsEvenValue(int value);
    }
}