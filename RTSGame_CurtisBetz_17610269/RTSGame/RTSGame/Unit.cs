using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGame
{
   abstract class Unit
    {
        private int xPosition;
        private int yPosition;
        private int health;
        private int speed;
        private int attack;
        private int attackRange;
        private string faction;
        private char symbol;

        public Unit()
        {
            xPosition = 0;
            yPosition = 0;
            health = 0;
            speed = 0;
            attack = 0;
            attackRange = 0;
            faction = "\0";
            symbol = '\0';
        }

        #region Accessors
        
        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        public int YPostion
        {
            get { return yPosition; }
            set { yPosition = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }

        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        #endregion


        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, char symbol)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
        }

        public void Move()
        {

        }

        public void Combat()
        {

        }

        public bool WithinRange()
        {

        }

        public void ClosestUnit()
        {

        }

        public bool isAlive()
        {

        }
        public string toString()
        {

        }
    }
}
