using Redux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo_Simple_MVVM_Redux.Model;
using Todo_Simple_MVVM_Redux.Redux.Actions.Todo;
using Todo_Simple_MVVM_Redux.Redux.State.Todo;
using Xamarin.Forms;

namespace Todo_Simple_MVVM_Redux.Redux.Reducers.Todo
{
    public class TodoReducer
    {
        public static TodoState Execute(TodoState previousState, IAction action)
        {
            switch (action)
            {
                case ToogleCompletedViewAction toogle:
                    previousState.ShowCompleted = !previousState.ShowCompleted;
                    break;

                case NewTodoAction newTodo:
                    var todo = new TodoItem()
                    {
                        Id = previousState.Todos.Max(x => x.Id) + 1,
                        Todo = newTodo.Todo
                    };

                    previousState.Todos.Add(todo);
                    break;

                case CompleteTodoAction com:
                    var todoID = previousState.Todos.First(t => t.Id == com.Id);
                    todoID.Completed = true;
                    break;
            }
            return previousState;
        }
    }
}
