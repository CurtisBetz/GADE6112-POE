using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGame
{
    class RangedUnit : Unit
    {
        private int rangedAttackRange;

        public RangedUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, char symbol)
            : base(xPosition, yPosition, health, speed, attack, attackRange, faction, symbol)
        {
            this.AttackRange = attackRange + 3;
        }

    }
}
