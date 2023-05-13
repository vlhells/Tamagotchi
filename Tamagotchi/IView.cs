using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class ViewUpdatedEventArgs: EventArgs
    {
        internal string BtnTextValue;

        public ViewUpdatedEventArgs(string btnTextValue)
        {
            BtnTextValue = btnTextValue;
        }
    }

    public interface IView
    {
        public abstract void Update(Dictionary<string, int> TamagotchiCharacteristics);
        public event EventHandler<ViewUpdatedEventArgs> ViewUpdated;
        public abstract void DieHandler();
    }
}
