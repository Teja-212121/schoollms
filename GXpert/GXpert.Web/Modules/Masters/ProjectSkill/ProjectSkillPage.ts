import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ProjectSkillGrid } from './ProjectSkillGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProjectSkillGrid($('#GridDiv')).element);
}