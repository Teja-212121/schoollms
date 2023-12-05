/** @jsxImportSource jsx-dom/min */
import { className } from "jsx-dom/min";
import { Todo } from "./todo-types";

const klass = (todo: Todo) => className([todo.done && "s-todo-done"]);

function todoDoneClick(e: Event) {
    var li = (e.target as Element).closest('li');
    var todo = (li as any)?.todo;
    if (todo) {
        todo.done = !todo.done;
        li.setAttribute("className", klass(todo));
    }
}

export const TodoItem = ({ todo }: { todo: Todo }) =>
    <li class={klass(todo)} {...{ todo }}>
        <span class="handle">
            <i class="fa fa-grip-vertical"></i>
        </span>
        <input type="checkbox" class="form-check-input" value="" onChange={todoDoneClick} />
        <span class="text">{todo.text}</span>
        <small class="label"><i class="fa fa-clock-o"></i> {todo.mins} mins</small>
    </li>