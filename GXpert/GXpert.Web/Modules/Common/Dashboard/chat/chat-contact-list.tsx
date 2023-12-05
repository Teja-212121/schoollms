/** @jsxImportSource jsx-dom/min */
import { ChatAvatar } from "./chat-avatar";
import { ChatContact } from "./chat-types";

export const ChatContactList = ({ contacts }: { contacts: ChatContact[] }) =>
    <div class="list-group">
        {contacts.map((contact, i) =>
            <a href="#" class={["list-group-item list-group-item-action border-0", i === 0 && "active"]} >
                {contact.unread && <div class="badge bg-success float-end">{contact.unread}</div>}
                <div class="d-flex align-items-start">
                    <ChatAvatar contact={contact} />
                    <div class="flex-grow-1 ms-3">
                        {contact.name}
                        <div class={["small", !contact.online && "opacity-50"]} >
                            <span class={["fas fa-dot-circle", contact.online ? "chat-online text-green" : "chat-offline text-gray"]}></span>
                            {contact.online ? "Online" : "Offline"}
                        </div>
                    </div>
                </div>
            </a>
        )}
    </div>
