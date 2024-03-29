import { ExamQuestionForQuestionForm, ExamQuestionForm, ExamQuestionRow, ExamQuestionService } from '@/ServerTypes/Exams';
import { Decorators, EntityDialog, ToolButton, notifySuccess } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Exams.ExamQuestionDialog')
export class ExamQuestionForQuestionDialog extends EntityDialog<ExamQuestionRow, any> {
    protected getFormKey() { return ExamQuestionForQuestionForm.formKey; }
    protected getService() { return ExamQuestionService.baseUrl; }

    protected form = new ExamQuestionForQuestionForm(this.idPrefix);
    private IsEditMode: boolean;
    private rowids: string;

    constructor(gridToRefresh, FormMode, selectedids) {
        super();
        this.IsEditMode = FormMode;
        this.rowids = selectedids;
        this.dialogTitle = "Assign Exam Question";
    }
    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();
        buttons.splice(0, 6);

        buttons.push({
            title: "Assign",
            cssClass: 'edit-permissions-button ',
            icon: 'fa-plus',
            onClick: () => {

                if (!this.validateBeforeSave())
                    return;
                this.entity.RowIds = this.rowids.toString();
                this.entity.ExamId = Number(this.form.ExamId.value);
                this.entity.ExamSectionId = Number(this.form.ExamSectionId.value);
                this.entity.SortOrder = this.form.SortOrder.value;
                this.entity.Marks = this.form.Marks.value;

                ExamQuestionService.AssignExam({
                    EntityId: 1,
                    Entity: this.entity

                }, response => {
                });
                notifySuccess("Assign Succesfully");
                this.dialogClose();
            }
        });

        buttons.push({
            title: "Cancel",
            icon: 'fa-minus',
            onClick: () => { this.dialogClose() }
        });
        return buttons;
    }
}