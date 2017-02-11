using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    // The Factory Design Pattern is part of the Creational Pattern category
    //reference from: http://scottlilly.com/c-design-patterns-the-factory-pattern/
    //The factory pattern allows developers to instantiate objects in a different way
    //Software developers can make changes once in a factory method instead of making changes in several places
    public class Player
    {
        public int HitPoints { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        // "internal" method allows developers to use method in a different class in the same project
        internal Player(int hitPoints, int experiencePoints, int gold)
        {
            HitPoints = hitPoints;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }
    }

        ////with method below, developers can write: Player player = new Player(10, 20, 5) in other classes;
        //public Player(int hitPoints, int experiencePoints, int gold)
        //{
        //    HitPoints = hitPoints;
        //    ExperiencePoints = experiencePoints;
        //    gold = Gold;
        //}

        //// Factory Method using "static" method:
        //public static Player CreateNewPlayer(int hitPoints, int experiencePoints, int gold)
        //{
        //    return new Player(hitPoints, experiencePoints, gold);
        //    // software developer can now write: Player player = Player.CreateNewPlayer(10, 20, 5);
        //    // Thus, developers can create "player" objects everywhere in program
        //}



    
}
