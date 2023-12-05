/** @jsxImportSource jsx-dom/min */
import { TodoItem } from "./todo-item";
import { Todo } from "./todo-types";

export const TodoList = ({ todos }: { todos: Todo[] }) =>
    <ul class="s-todo-list" ref={ul => {
        ($(ul) as any).on('change', (e: any) => {
            let li = e.target.closest('li');
            li && li.classList.toggle('s-todo-done');
            let todo = (li as any).todo;
            todo && (todo.done = !todo.done);
        }).sortable?.({
            placeholder: "sort-highlight",
            handle: ".handle",
            forcePlaceholderSize: true,
            zIndex: 999999,
        })
    }}>
        {todos.map(todo => <TodoItem todo={todo} />)}
    </ul>

