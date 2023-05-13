using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Presenter
    {
        private Tamagotchi _model = null;
        private IView _view = null;

        internal Presenter(Tamagotchi model, IView view)
        {
            _model = model;
            _view = view;

            _view.ViewUpdated += ViewModelUpdate;
            _model.ModelUpdated += ModelViewUpdate;
            _model.TamagotchiHasDie += ModelViewUpdate;
            _model.TamagotchiHasDie += ModelDieViewHandler;
        }

        private void ModelDieViewHandler(object sender, EventArgs e)
        {
            _view.DieHandler();
        }

        internal IView ShowView()
        {
            return _view;
        }

        private void ModelViewUpdate(object sender, TamagotchiMdUpdatedEventArgs e)
        {
            _view.Update(e.TamagotchiCharacteristics);
        }

        private void ViewModelUpdate(object sender, ViewUpdatedEventArgs e)
        {
            switch (e.BtnTextValue)
            {
                case "Покормить питомца":
                    TamagotchiEat();
                    break;

                case "Погулять с питомцем":
                    TamagotchiWalk();
                    break;

                case "Погладить питомца":
                    TamagotchiPet();
                    break;
            }
        }

        private void TamagotchiEat()
        {
            _model.Eat();
        }

        private void TamagotchiWalk()
        {
            _model.Walk();
        }

        private void TamagotchiPet()
        {
            _model.Pet();
        }
    }
}
