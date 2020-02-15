using HackerRank.Algorithms.RepeatedString.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.Algorithms.RepeatedString
{
    public class RepeatedStringFactory : IFactory<RepeatedStringAuthors, IRepeatedString>
    {
        public IRepeatedString GetObject(RepeatedStringAuthors type)
        {
            switch (type)
            {
                case RepeatedStringAuthors.Ouro17:
                    return new RepeatedStringOuro17();
                default:
                    throw new NotSupportedException();
            }
        }


        public IRepeatedString GetObject(RepeatedStringAuthors type, object[] parameters)
        {
            switch (type)
            {
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
