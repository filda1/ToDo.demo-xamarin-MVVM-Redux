using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_Simple_MVVM_Redux.Model;
using Todo_Simple_MVVM_Redux.Redux.Actions.Todo;
using Todo_Simple_MVVM_Redux.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo_Simple_MVVM_Redux.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        Page1ViewModel vm;

        Page1ViewModel VM
        {
            get => vm ?? (vm = (Page1ViewModel) BindingContext);
        }


         public Page2()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!(sender is CheckBox toogle)) return;
            if (!(toogle.BindingContext is TodoItem todoItem)) return;

            //App.TodosStore.Dispatch(new CompleteTodoAction(todoItem.Id));
        }
    }
}