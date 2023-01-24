using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet7
{
    public class Health
    {
        int _health;
        private int _maxHealth;

        public int Health_ { get => _health; set => _health = value; }
        public int ShortHealth { get; set; }
        public int MaxHealth_ { get => _maxHealth; set => _maxHealth = value; }

        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth(int value)
        {
            _health = value;
        }
    }
}
