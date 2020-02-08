using HackerRank.Algorithms.JumpingOnTheClouds.Implementations;
using HackerRank.Utils;
using System;

namespace HackerRank.Algorithms.JumpingOnTheClouds
{
    public class JumpingOnTheCloudsFactory : IFactory<JumpingOnTheCloudsAuthors, IJumpingOnTheClouds>
    {
        public IJumpingOnTheClouds GetObject(JumpingOnTheCloudsAuthors type)
        {
            switch (type)
            {
                case JumpingOnTheCloudsAuthors.Ouro17:
                    return new JumpingOnTheCloudsOuro17();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
