using GamePrototype.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Utils
{
    public abstract class UnitFactoryDemoAbstract
    {
        public abstract Unit CreateGoblinEnemy();
    }

    public class UnitFactoryDemoEasy : UnitFactoryDemoAbstract
    {
        public override Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 5, 5, 1);
    }

    public class UnitFactoryDemoMedium : UnitFactoryDemoAbstract
    {
        public override Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 10, 10, 2);
    }

    public class UnitFactoryDemoHard : UnitFactoryDemoAbstract
    {
        public override Unit CreateGoblinEnemy() => new Goblin(GameConstants.Goblin, 15, 15, 3);
    }
}
