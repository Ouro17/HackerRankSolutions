namespace HackerRank.Algorithms.JumpingOnTheClouds.Implementations
{
    public class JumpingOnTheCloudsOuro17 : IJumpingOnTheClouds
    {
        public int JumpingOnClouds(int[] c)
        {
            int steps = 0;
            int cloud = 0;
            bool calculating = true;
            int lastPosition = c.Length - 1;

            while (calculating)
            {
                if (cloud + 1 >= lastPosition || cloud + 2 >= lastPosition)
                {
                    steps++;
                    calculating = false;
                }
                else
                {
                    cloud += (c[cloud + 2] != 1) ? 2 : 1;
                    steps++;
                }
            }

            return steps;
        }
    }
}
