import { initFullHeightGridPage } from '@serenity-is/corelib';
import { PreDefinedKeyGrid } from './PreDefinedKeyGrid';

export default function pageInit() {
    initFullHeightGridPage(new PreDefinedKeyGrid($('#GridDiv')).element);
}