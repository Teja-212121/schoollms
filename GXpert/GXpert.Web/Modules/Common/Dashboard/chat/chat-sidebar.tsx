/** @jsxImportSource jsx-dom/min */
import { ChatAvatar } from "./chat-avatar";
import { ChatContactList } from "./chat-contact-list";
import { contacts, ownContact } from "./chat-mock-data";

export const ChatSidebar = () => <div class="col-12 col-lg-5 col-xl-4 s-chat-sidebar">
    <div class="d-flex align-items-center justify-content-center p-3 s-chat-profile-section">
        <div class="dropdown">
            <a class="btn" data-bs-toggle="dropdown">
                <ChatAvatar contact={ownContact} profile />
                <span class="ms-1">
                    {ownContact.name}
                </span>
                <i class="fa fa-chevron-down expand-button text-muted"></i>
            </a>
            <ul class="dropdown-menu">
                <li id="status-online"><a class="dropdown-item"><i class="fa fa-dot-circle text-green"></i> Online</a></li>
                <li id="status-away"><a class="dropdown-item"><i class="fa fa-dot-circle text-blue"></i> Away</a></li>
                <li id="status-busy"><a class="dropdown-item"><i class="fa fa-dot-circle text-red"></i> Busy</a></li>
                <li id="status-offline"><a class="dropdown-item"><i class="fa fa-dot-circle text-gray opacity-50"></i> Offline</a></li>
            </ul>
        </div>
    </div>

    <div class="d-flex align-items-center px-2">
        <div class="flex-grow-1">
            <input type="text" class="form-control mb-3" placeholder="Search contacts..." />
        </div>
    </div>

    <ChatContactList contacts={contacts} />
</div>
