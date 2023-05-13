using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class TamagotchiMdUpdatedEventArgs : EventArgs
    {
        internal Dictionary<string, int> TamagotchiCharacteristics { get; private set; }

        internal TamagotchiMdUpdatedEventArgs(Dictionary<string, int> _tamagotchiCharacteristics)
        {
            TamagotchiCharacteristics = _tamagotchiCharacteristics;
        }

    }

    internal class Tamagotchi
    {
        internal Dictionary<string, int> TamagotchiCharacteristics;

        internal event EventHandler<TamagotchiMdUpdatedEventArgs> ModelUpdated = delegate { };

        internal event EventHandler<TamagotchiMdUpdatedEventArgs> TamagotchiHasDie = delegate { };

        internal Tamagotchi()
        {
            TamagotchiCharacteristics = new Dictionary<string, int>()
            {
                {"HP", 100},
                {"Hunger", 0},
                {"Happiness", 100},
                {"Energy", 100}
            };
        }

        internal void Eat()
        {
            TamagotchiCharacteristics["HP"] += 40;
            TamagotchiCharacteristics["Energy"] += 50;
            TamagotchiCharacteristics["Happiness"] += 80;
            TamagotchiCharacteristics["Hunger"] -= 25;

            if (TamagotchiCharacteristics["HP"] > 100)
                TamagotchiCharacteristics["HP"] = 100;
            if (TamagotchiCharacteristics["Energy"] > 100)
                TamagotchiCharacteristics["Energy"] = 100;
            if (TamagotchiCharacteristics["Happiness"] > 100)
                TamagotchiCharacteristics["Happiness"] = 100;
            if (TamagotchiCharacteristics["Hunger"] < 0)
                TamagotchiCharacteristics["Hunger"] = 0;

            ModelUpdated.Invoke(this, new TamagotchiMdUpdatedEventArgs(TamagotchiCharacteristics));
        }

        internal void Walk()
        {
            TamagotchiCharacteristics["Hunger"] += 30;
            if (TamagotchiCharacteristics["Hunger"] > 100)
                TamagotchiCharacteristics["Hunger"] = 100;

            if (TamagotchiCharacteristics["Energy"] > 0)
            {
                TamagotchiCharacteristics["Energy"] -= 25;
                TamagotchiCharacteristics["Happiness"] += 45;
            }

            if (TamagotchiCharacteristics["Happiness"] < 0)
                TamagotchiCharacteristics["Happiness"] = 0;
            else if (TamagotchiCharacteristics["Happiness"] > 100)
                TamagotchiCharacteristics["Happiness"] = 100;

            if (TamagotchiCharacteristics["Energy"] <= 0)
            {
                TamagotchiCharacteristics["Energy"] = 0;
                TamagotchiCharacteristics["HP"] -= 25;
                TamagotchiCharacteristics["Happiness"] -= 15;
            }

            if (TamagotchiCharacteristics["HP"] < 0)
                TamagotchiCharacteristics["HP"] = 0;

            if (TamagotchiCharacteristics["HP"] == 0 || TamagotchiCharacteristics["Hunger"] == 100)
                TamagotchiHasDie.Invoke(this, new TamagotchiMdUpdatedEventArgs(TamagotchiCharacteristics));
            else
                ModelUpdated.Invoke(this, new TamagotchiMdUpdatedEventArgs(TamagotchiCharacteristics));
        }

        internal void Pet()
        {
            TamagotchiCharacteristics["Happiness"] += 40;
            if (TamagotchiCharacteristics["Happiness"] > 100)
                TamagotchiCharacteristics["Happiness"] = 100;

            ModelUpdated.Invoke(this, new TamagotchiMdUpdatedEventArgs(TamagotchiCharacteristics));
        }
    }
}
