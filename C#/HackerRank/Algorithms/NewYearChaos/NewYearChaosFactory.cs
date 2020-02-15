using HackerRank.Algorithms.NewYearChaos.Implementations;
using HackerRank.Utils;
using System;
using System.IO;

namespace HackerRank.Algorithms.NewYearChaos
{
    public class NewYearChaosFactory : IFactory<NewYearChaosAuthors, INewYearChaos>
    {
        public INewYearChaos GetObject(NewYearChaosAuthors type)
        {
            switch (type)
            {
                default:
                    throw new NotSupportedException();
            }
        }

        public INewYearChaos GetObject(NewYearChaosAuthors type, object[] parameters)
        {
            switch (type)
            {
                case NewYearChaosAuthors.Ouro17:
                    return new NewYearChaosOuro17((TextWriter)parameters[0]);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
