namespace PokemonLike.MVVM.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        static public Action<BaseVM> OnRequestChangeVM { get; set; }


        public MainWindowVM()
        {
            OnRequestChangeVM += HandleChangeVM;
            ;
            OnRequestChangeVM?.Invoke(new MenuViewVM());
        }

        private void HandleChangeVM(BaseVM vM)
        {
            CurrentVM = vM;
        }


        private BaseVM _currentVM;
        public BaseVM CurrentVM
        {
            get => _currentVM;
            set
            {
                SetProperty(ref _currentVM, value);
            }
        }







        //public void HandleRequestViewChange(BaseVM a_VMToChange)
        //{
        //    //Notify currentVM will be hide
        //    CurrentVM?.OnHideVM();

        //    // Assign the new VM
        //    CurrentVM = a_VMToChange;

        //    //Notify currentVM will be shown
        //    CurrentVM?.OnShowVM();
        //}

    }
}
