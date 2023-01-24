using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet7
{
    public class Attack
    {
        private int _damage;
        private int _type;
        private int _type2;
        private int _manaCost;

        public int Damage_ { get => _damage; set => _damage = value; }
        public int Type_ { get => _type; set => _type = value; }
    }
}