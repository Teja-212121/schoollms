import { initFullHeightGridPage } from '@serenity-is/corelib';
import { QuestionGrid } from './QuestionGrid';

export default function pageInit() {
    initFullHeightGridPage(new QuestionGrid($('#GridDiv')).element);
}