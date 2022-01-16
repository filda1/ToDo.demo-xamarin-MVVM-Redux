using Redux;
using System;
using Todo_Simple_MVVM_Redux.Redux.Reducers.Todo;
using Todo_Simple_MVVM_Redux.Redux.State.Todo;
using Todo_Simple_MVVM_Redux.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// INSTALAR Redux.NET
// INSTALR Linq
namespace Todo_Simple_MVVM_Redux
{
    public partial class App : Application
    {

        public static Store<TodoState> TodosStore { get; private set; }

        public App()
        {
            InitializeComponent();

            //Coneccion Globla con Store
            TodosStore = new Store<TodoState>(TodoReducer.Execute, TodoState.InitialState);

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
