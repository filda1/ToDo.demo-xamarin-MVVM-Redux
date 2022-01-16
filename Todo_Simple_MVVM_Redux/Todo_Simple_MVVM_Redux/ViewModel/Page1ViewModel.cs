using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Todo_Simple_MVVM_Redux.Model;
using Todo_Simple_MVVM_Redux.Redux.Actions.Todo;
using Todo_Simple_MVVM_Redux.View;
using Xamarin.Forms;

namespace Todo_Simple_MVVM_Redux.ViewModel
{
    public class Page1ViewModel:Base1ViewModel
    {
        //Type data
        private string inputvalue;
        private ObservableCollection<TodoItem> todo;

        //ObserverCollection
        public ObservableCollection<TodoItem> Listodo
        {
            get { return this.todo; }
            set { SetValue(ref this.todo, value); }
        }

        //Properties 
        public string InputValue
        {
            get { return this.inputvalue; }
            set
            {
                SetValue(ref this.inputvalue, value);
            }
        }

    
        //Commands
        public Command OnButtonCompleted { get; set; }
        public Command OnAddTask { get; set; }

        public Command OnButtonNext { get; set; }

        public Page1ViewModel()
        {
     
            App.TodosStore.Subscribe(state =>
            {
                this.Listodo = new ObservableCollection<TodoItem>(state.Todos
                    .Where( x => state.ShowCompleted ? x.Completed : !x.Completed)
                    );
            }
            );

            OnButtonCompleted = new Command(OnButtonBoxCompleted);

            OnAddTask = new Command(OnAddTaskTrigger);

            OnButtonNext = new Command(OnPageNext);
        }

  

        //Methods
        private void OnButtonBoxCompleted(object obj)
        {
            /*Application.Current.MainPage.DisplayAlert(
              "Like",
              "OKAY",
             "Accept"); */

            App.TodosStore.Dispatch(new ToogleCompletedViewAction());
        }

        private void OnAddTaskTrigger(object obj)
        {         
            App.TodosStore.Dispatch(new NewTodoAction(this.InputValue.ToString()));
            this.InputValue = string.Empty;
        }

        private async void OnPageNext(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Page2());
        }
    }
}
