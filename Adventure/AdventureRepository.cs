using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class AdventureRepository
    {
        private Hero _hero;

        public void CreateHero(string name)
        {
            _hero = new Hero
            {
                Name = name,
                Energy = 7,
                HasEnergy = true
            };
        }

        public Hero CharacterDetails()
        {
            return _hero;
        }

        public int CheckEnergy()
        {
            return _hero.Energy;
        }

        public void IncreaseEnergy()
        {
            _hero.Energy += 1;
        }

        public void DecreaseEnergy()
        {
            _hero.Energy -= 1;
        }

    }
}
