/** @jsxImportSource jsx-dom/min */
import { ChatAvatar } from "./chat-avatar";
import { otherContact } from "./chat-mock-data";

export const ChatHeader = () => <div class="s-chat-header py-2 px-4 d-none d-lg-block">
    <div class="d-flex align-items-center py-1">
        <div class="position-relative">
            <ChatAvatar contact={otherContact} />
        </div>
        <div class="flex-grow-1 ps-3">
            <div class="text-muted small"><em>Typing...</em></div>
        </div>
        <div>
            <button class="btn btn-lg me-2 px-3"><i class="fa fa-phone"></i></button>
            <button class="btn btn-lg me-2 px-3"><i class="fa fa-video"></i></button>
            <button class="btn btn-lg px-2"><i class="fa fa-ellipsis-v"></i></button>
        </div>
    </div>
</div>
