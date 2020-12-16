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

        /// <summary>
        /// Constructor with parameter
        /// </summary>
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

        /// <summary>
        /// Adding private string
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Added public string
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// New public method
        /// </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Override tosting method
        /// </summary>
        public override string ToString()
        {
            return String.Format ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}