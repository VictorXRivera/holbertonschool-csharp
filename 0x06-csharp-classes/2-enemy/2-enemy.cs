using System;

namespace Enemies
{
    ///<summary>Public class Zombie defining zombie within the Enemies namespace</summary>///
    public class Zombie
    {
        ///<summary>Public constructor</summary>///
        public Zombie()
        {
            this.health = 0;
        }
        ///<summary>Public constructor checking if value is equal or greater than 0</summary>///
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        ///<summary>public int field</summary>///
        public int health;
    }
}