using System;

namespace Enemies
{
    ///<summary>Public class Zombie defining zombie within the Enemies namespace</summary>///
    public class Zombie
    {
        ///<summary>Private int field</summary>///
        private int health;
        ///<summary>Private string field</summary>///
        private string name = "(No name)";
        ///<summary>Public property</summary>///
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        ///<summary>Public constructor</summary>///
        public Zombie()
        {
            this.health = 0;
        }
        ///<summary>Public constructor checking if value is equal or greater than 0</summary>///
        public Zombie(int? value = 0)
        {
            if (value < 0 || value.HasValue == false)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value.GetValueOrDefault();
        }
        ///<summary>Method that returns health of Zombie</summary>
        public int GetHealth()
        {
            return (health);
        }
    }
}