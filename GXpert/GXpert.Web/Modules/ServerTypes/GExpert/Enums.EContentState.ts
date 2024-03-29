import { Decorators } from "@serenity-is/corelib";

export enum EContentState {
    PUBLIC = 0,
    PRIVATE = 1
}
Decorators.registerEnumType(EContentState, 'GExpert.Enums.EContentState', 'Enums.EContentState');