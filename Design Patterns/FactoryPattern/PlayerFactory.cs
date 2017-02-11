using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public static class PlayerFactory
    {
        //// Now developer can create new Player object in another class:
        //// Player player = PlayerFactory.LoadPlayer();
        //public static Player LoadPlayer()
        //{
        //    return new Player(10, 20, 5);
        //}

        //using the following Factory Method, allows a developer to make changes in one place and not require making changes in several places in the program
        public static Player LoadPlayer()
        {
            if (File.Exists("SavedGameData.xml"))
            {
                int xmlHitPoints = 20;
                int xmlExperiencePoints = 100;
                int xmlGold = 10;

                return new Player(xmlHitPoints, xmlExperiencePoints, xmlGold);
            }

            else
            {
                return new Player(10, 20, 5);
            }
            // Then use the following instantiation elsewhere: Player player = PlayerFactory.LoadPlayer();
        }



        
    }
}
