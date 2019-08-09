using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2Anchor9
{
    class combatClass
    {
        //ATRIBUTOS

        private string name;
        private int attackPoints;
        private bool hero;
        private string type;
        private string effect;


        //public combatClass(string name, int attackPoints, bool hero, string type, string effect);

        public string Name { get => name; set => name = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
        public bool Hero {get => hero; set => hero = value;  }


    }

}
