import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PrincipalGrid } from './PrincipalGrid';

export default function pageInit() {
    initFullHeightGridPage(new PrincipalGrid($('#GridDiv')).element);
}