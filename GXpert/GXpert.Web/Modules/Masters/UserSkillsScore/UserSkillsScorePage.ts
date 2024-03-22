import { initFullHeightGridPage } from '@serenity-is/corelib';
import { UserSkillsScoreGrid } from './UserSkillsScoreGrid';

export default function pageInit() {
    initFullHeightGridPage(new UserSkillsScoreGrid($('#GridDiv')).element);
}