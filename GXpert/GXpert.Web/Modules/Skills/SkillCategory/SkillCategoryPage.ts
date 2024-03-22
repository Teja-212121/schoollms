import { initFullHeightGridPage } from '@serenity-is/corelib';
import { SkillCategoryGrid } from './SkillCategoryGrid';

export default function pageInit() {
    initFullHeightGridPage(new SkillCategoryGrid($('#GridDiv')).element);
}