using System;
using System.IO;
using HackerRank.Algorithms.NewYearChaos.Implementations;
using HackerRank.Utils;
using HackerRank.Utils.TextWriterFactories;

namespace HackerRank.Algorithms.NewYearChaos
{
    public class NewYearChaosFactory : IFactory<NewYearChaosAuthors, INewYearChaos>
    {
        private readonly IFactory<TextWriterEnum, TextWriter> _textWriterFactory;

        public NewYearChaosFactory(IFactory<TextWriterEnum, TextWriter> textWriterFactory)
        {
            _textWriterFactory = textWriterFactory;
        }

        public INewYearChaos GetObject(NewYearChaosAuthors type)
        {
            switch (type)
            {
                case NewYearChaosAuthors.Ouro17:
                    return new NewYearChaosOuro17(_textWriterFactory.GetObject(TextWriterEnum.StringBuilder));
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
