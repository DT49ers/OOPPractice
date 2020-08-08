using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Human Cyborg = new Human("Cyborg1");
            Console.WriteLine($"I am {Cyborg.Name} from planet Kyptos");
            Console.WriteLine(Cyborg.Intelligence);
            Console.WriteLine(Cyborg.Health);
            Console.WriteLine(Cyborg.Dexterity);

            Human GalaticMan = new Human("Mr.Galactic", 100, 100, 100, 100);
            Console.WriteLine(GalaticMan.Dexterity);
            Console.WriteLine(GalaticMan.Health);
            Console.WriteLine(GalaticMan.Strength);
            Console.WriteLine(GalaticMan.Intelligence);

            Cyborg.Attack(GalaticMan);
            Console.WriteLine($"After the attack the remaining health of GalaticMan is {GalaticMan.Health}");
    
        }

        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
            public int Health
            {
                get 
                { 
                    return health; 
                }
                set 
                { 
                    health = value; 
                }
            }
            
            public Human(string aName)
            {
                Name = aName;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;

            }
            public Human(string aName, int aStrength, int aIntelligence, int aDexterity, int ahealth)
            {
                Name = aName;
                Strength = aStrength;
                Intelligence = aIntelligence;
                Dexterity = aDexterity;
                health = ahealth;
            }
            // add a public "getter" property to access health
            
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            
            // Add a constructor to assign custom values to all fields
            
            // Build Attack method
            public int Attack(Human target)
            {
                int attack;
                attack = 5 * this.Strength;
                target.Health -= attack;
                return health;
            }
        }
    }
}
