import { UserSkillsScoreColumns, UserSkillsScoreRow, UserSkillsScoreService } from '@/ServerTypes/Masters';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UserSkillsScoreDialog } from './UserSkillsScoreDialog';

@Decorators.registerClass('GXpert.Masters.UserSkillsScoreGrid')
export class UserSkillsScoreGrid extends EntityGrid<UserSkillsScoreRow, any> {
    protected getColumnsKey() { return UserSkillsScoreColumns.columnsKey; }
    protected getDialogType() { return UserSkillsScoreDialog; }
    protected getRowDefinition() { return UserSkillsScoreRow; }
    protected getService() { return UserSkillsScoreService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected addButtonClick() {
        this.editItem({ StudentId: this.StudentId });
    }

    protected getInitialTitle() {
        return null;
    }

    protected getGridCanLoad() {
        return super.getGridCanLoad() && !!this.StudentId;
    }

    private _StudentId: string;

    get StudentId() {
        return this._StudentId;
    }

    set StudentId(value: string) {
        if (this._StudentId !== value) {
            this._StudentId = value;
            this.setEquality('StudentId', value);
            this.refresh();
        }
    }
}