using System;
using Xamarin.Forms;

using Industrious.Redux;

namespace Musicality.Remote.Forms
{
    public partial class App : Application
    {
        private readonly IStore<AppState> _store;
        private readonly AppPageNavigator _pageNavigator;

         
        public App()
        {
            InitializeComponent();

			_store = new Store<AppState>(Reducers.Root, AppState.Empty);
			_pageNavigator = new AppPageNavigator();

            MainPage = new MainPage();
        }
    }
}
