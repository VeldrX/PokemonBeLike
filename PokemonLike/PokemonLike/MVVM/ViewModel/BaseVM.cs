using CommunityToolkit.Mvvm.ComponentModel;

namespace PokemonLike.MVVM.ViewModel
{
    public class BaseVM : ObservableObject
    {

        public virtual void OnShowVM() { }
        public virtual void OnHideVM() { }

    }
}
