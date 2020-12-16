using System;

namespace Enemies
{
    /// <summary>
    /// Defining public class Zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Variable for health
        /// </summary>
        public int health;

        /// <summary>
        /// Zombie constructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}