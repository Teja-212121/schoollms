import { CourseForm, CourseRow, CourseService } from '@/ServerTypes/Syllabus';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Syllabus.CourseDialog')
export class CourseDialog extends EntityDialog<CourseRow, any> {
    protected getFormKey() { return CourseForm.formKey; }
    protected getRowDefinition() { return CourseRow; }
    protected getService() { return CourseService.baseUrl; }

    protected form = new CourseForm(this.idPrefix);
}