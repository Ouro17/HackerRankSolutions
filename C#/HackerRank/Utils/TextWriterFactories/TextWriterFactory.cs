using System;
using System.IO;
using System.Text;

namespace HackerRank.Utils.TextWriterFactories
{
    public class TextWriterFactory : IFactory<TextWriterEnum, TextWriter>
    {
        public TextWriter GetObject(TextWriterEnum type)
        {
            switch(type)
            {
                case TextWriterEnum.StringBuilder:
                    return new StringWriter(new StringBuilder());
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
