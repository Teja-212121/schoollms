import { ServiceRequest } from "@serenity-is/corelib";

export interface SignUpRequest extends ServiceRequest {
    DisplayName?: string;
    Mobile?: string;
    Email?: string;
    Password?: string;
    Recaptcha?: string;
    ExternalProviderToken?: string;
}