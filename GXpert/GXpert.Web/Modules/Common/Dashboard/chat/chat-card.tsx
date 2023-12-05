/** @jsxImportSource jsx-dom/min */
import { messageList } from "./chat-mock-data";
import { ChatMessages } from "./chat-messages";
import { ChatHeader } from "./chat-header";
import { ChatSidebar } from "./chat-sidebar";

export const ChatCard = () =>
    <div class="card s-dashboard-card s-chat">
        <div class="row g-0" data-status="online">
            <ChatSidebar />

            <div class="col-12 col-lg-7 col-xl-8">
                <ChatHeader />

                <div class="position-relative">
                    <ChatMessages messages={messageList} />
                </div>

                <div class="flex-grow-0 py-3 px-4">
                    <div class="input-group">
                        <input type="text" class="form-control" placeholder="Type your message" />
                        <button class="btn btn-primary">Send</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
