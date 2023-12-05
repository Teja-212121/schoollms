/** @jsxImportSource jsx-dom/min */
import { DashboardPageModel } from "@/ServerTypes/Common/DashboardPageModel";
import { format } from "@serenity-is/corelib";
import { CalendarCard } from "./calendar/calendar-card";
import { ChatCard } from "./chat/chat-card";
import { OrdersCard } from "./orders/orders-card";
import { SmallCard } from "./shared/small-card";
import { TodoCard } from "./todo/todo-card";
import { TrafficCard } from "./traffic/traffic-card";
import { VisitorsCard } from "./visitors/visitors-card";

export default function pageInit({ model, nwLinkFormat }: { model: DashboardPageModel, nwLinkFormat: string }) {

    const nwLink = (s: string) => format(nwLinkFormat, s);

    document.getElementById("DashboardContent").append(<>
        <div class="row">
            <SmallCard caption="Open Orders" icon="shopping-cart" url={nwLink("Order?shippingState=0")} value={model.OpenOrders} />
            <SmallCard caption="Closed Orders" icon="truck" url={nwLink("Order?shippingState=1")} value={<>{model.ClosedOrderPercent}<sup style="font-size: 20px">%</sup></>} />
            <SmallCard caption="Total Customers" icon="user-plus" url={nwLink("Customer")} value={model.CustomerCount} />
            <SmallCard caption="Product Types" icon="tag" url={nwLink("Product")} value={model.ProductCount} />
        </div>

        <div class="row">
            <section class="col-lg-7">
                <OrdersCard />
                <ChatCard />
                <TodoCard />
            </section>

            <section class="col-lg-5">
                <VisitorsCard />
                <TrafficCard />
                <CalendarCard />
            </section>
        </div>
    </>)
}