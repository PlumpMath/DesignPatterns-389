using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public static class MonsterFactory
    {
        public static Monster GetRandomMonster()
        {
            int randomNumber = 2;

            switch(randomNumber)
            {
                case 1:
                    return new FlyingMonster();
                case 2:
                    return new LandMonster();
                default:
                    return new SeaMonster();
            }
        }
        // developer can now create monster objects: Monster monster = MonsterFactory(GetRandomMonster);
    }
}
