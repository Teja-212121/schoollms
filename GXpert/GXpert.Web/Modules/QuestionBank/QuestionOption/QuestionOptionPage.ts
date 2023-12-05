import { initFullHeightGridPage } from '@serenity-is/corelib';
import { QuestionOptionGrid } from './QuestionOptionGrid';

export default function pageInit() {
    initFullHeightGridPage(new QuestionOptionGrid($('#GridDiv')).element);
}