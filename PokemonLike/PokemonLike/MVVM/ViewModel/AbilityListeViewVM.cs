using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class AbilityListeViewVM : BaseVM
    {

        private readonly ExerciceMonsterContext _dbContext;
        public ObservableCollection<Spell> Abilities { get; set; }
        public ICommand NavigateToAbilityInfoCommand { get; }
        public ICommand NavigateToGameCommand { get; }


        public AbilityListeViewVM()
        {
            _dbContext = new ExerciceMonsterContext();
            LoadAbilities();
            NavigateToAbilityInfoCommand = new RelayCommand<Spell>(NavigateToAbilityInfo);
            NavigateToGameCommand = new RelayCommand(NavigateToGameView);

        }

        private void LoadAbilities()
        {
            Abilities = new ObservableCollection<Spell>(_dbContext.Spells);
        }


        private void NavigateToAbilityInfo(Spell selectedSpell)
        {
            if (selectedSpell != null)
            {
                MainWindowVM.OnRequestChangeVM?.Invoke(new AbilityInfoViewVM(selectedSpell));
            }
        }

        private void NavigateToGameView()
        {
            MainWindowVM.OnRequestChangeVM?.Invoke(new GameViewVM());
        }
    }
}
