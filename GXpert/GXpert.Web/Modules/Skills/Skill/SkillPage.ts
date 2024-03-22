import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SkillGrid } from './SkillGrid';

export default function pageInit() {
    initFullHeightGridPage(new SkillGrid($('#GridDiv')).element);
}