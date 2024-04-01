import { Decorators, notifyWarning } from "@serenity-is/corelib";
import { WizardDialog } from "@serenity-is/pro.extensions";
import { ExamRow, ExamService, ExamWizardForm } from "../../ServerTypes/Exams";
namespace GXpert.Exams {

    /**
     * An order wizard that extends Serenity.WizardDialog, available only in premium version
     */
   @Decorators.panel()
    export class ExamWizard extends WizardDialog<ExamRow, any> {
        protected getFormKey() { return ExamWizardForm.formKey; }
        protected getLocalTextPrefix() { return ExamRow.localTextPrefix; }

        protected form = new ExamWizardForm(this.idPrefix);
        private IsExamSaved: boolean = false;
        private ExamId: number;
        constructor() {
            super();

            this.dialogTitle = "Exam Wizard";

            // auto enable / disable customer selection dropdown when radio buttons change
            //this.form.CustomerType.change(e => {

            //var isNewExam = this.isNewExam;
            //    Serenity.EditorUtils.setReadOnly(this.form.ExistingCustomerID, isNewCustomer);
            //    Serenity.EditorUtils.setRequired(this.form.ExistingCustomerID, !isNewCustomer);
            //    // open dropdown when existing customer radio button is clicked
            //    if (!isNewCustomer)
            //        setTimeout(() => {
            //            (this.form.ExistingCustomerID.element as any).select2('open');
            //        }, 0);
            //});
        }

        //private get isNewCustomer() {
        //    return this.form.CustomerType.value != OrderWizardCustomerType.Existing.toString();
        //}

        /**
         * next method is called when user tries to go forward
         * @param toStep the step user is trying to move to, usually one step ahead
         */
       protected next(toStep: number) {
           if (toStep == ExamWizardSteps.ExamDetails) {
                // if user is trying to move forward to custom details step and 
                // we are using an existing customer, skip the customer details step
                //if (!this.isNewCustomer)
                //    toStep = OrderWizardSteps.OrderInfo;
            }
           else if (this.step == ExamWizardSteps.ExamSections) {

                // validate that details list not empty before moving away from details step
                if (!this.form.ExamSection.value.length) {
                    notifyWarning("Please enter at least one detail!");
                    return;
                }
                else {
                    if (this.IsExamSaved == false) {

                        var order = this.getSaveEntity([
                            ExamWizardSteps.ExamSections,
                            ExamWizardSteps.ExamQuestions,
                        ]);
                        var exam = this.getSaveEntity([ExamWizardSteps.ExamDetails]) as ExamRow;
                        exam.ExamSection = order.ExamSection
                        ExamService.Create({
                            Entity: exam
                        }, response => {
                            debugger;
                            //this.saveOrder(exam.Id);
                            //Q.confirm('New Exam with ID:  is created. Would you like to add another one?', () => {
                            //    this.reset();
                            //}, {
                            //    onNo: () => this.dialogClose(),
                            //    onCancel: () => this.dialogClose(),
                            //    onClose: () => this.dialogClose()
                            //});
                            this.ExamId = response.EntityId;
                            this.IsExamSaved = true;
                            ExamService.Retrieve({
                                EntityId: response.EntityId
                            }, examresponse => {
                                this.form.Title.value = examresponse.Entity.Title;
                            });

                        });
                    }
                    else {
                        var order = this.getSaveEntity([
                            ExamWizardSteps.ExamSections,
                            ExamWizardSteps.ExamQuestions,
                        ]);
                        var exam = this.getSaveEntity([ExamWizardSteps.ExamDetails]) as ExamRow;
                        exam.ExamSection = order.ExamSection
                        ExamService.Update({
                            Entity: exam,
                            EntityId: this.ExamId
                        });
                    }

                }
            }
           else if (toStep == ExamWizardSteps.ExamSections) {
                // when moving into details step, if details are empty, auto open add detail dialog
                if (!this.form.ExamSection.value.length) {
                    this.step = toStep;
                    this.form.ExamSection.element.find('.add-button').click();
                    return;
                }
            }
           else if (toStep == ExamWizardSteps.ExamQuestions) {
                // when moving into details step, if details are empty, auto open add detail dialog
                if (!this.form.ExamQuestions.value.length) {
                    this.step = toStep;
                    this.form.ExamQuestions.element.find('.add-button').click();
                    return;
                }
            }

            // you should call setStep after validating / modifying target step (toStep)
            this.step = toStep;
        }

        /**
         * back method is called when user tries to go backward
         * @param toStep the step user is trying to move to, usually one step back but can also be multiple
         */
        protected back(toStep: number) {
            if (toStep == ExamWizardSteps.ExamDetails) {
                // if using existing customer, skip back to first step
                // toStep = OrderWizardSteps.CustomerSelection;
            }

            this.step = toStep;
        }

        /**
         * called to reset the form, and go back to first step
         */
        protected reset() {
            super.reset();

            // we need to clear readonly / required state of existing customer selection
            // as base reset method won't reset its state, only form values
            //Serenity.EditorUtils.setReadOnly(this.form.ExistingCustomerID, true);
            //Serenity.EditorUtils.setRequired(this.form.ExistingCustomerID, false);
        }

        /**
         * is called when user clicks the Finish button (next button on last step)
         */
        protected finish() {
            debugger;
            // if new customer type, first create customer by getting properties
            // from only the CustomerDetails step
            var order = this.getSaveEntity([
                ExamWizardSteps.ExamSections,
                ExamWizardSteps.ExamQuestions,
            ]);
            var exam = this.getSaveEntity([ExamWizardSteps.ExamDetails]) as ExamRow;
            exam.ExamSection = order.ExamSection;
            exam.ExamQuestions = order.ExamQuestions;
            exam.IsActive = true;
            ExamService.Update({
                Entity: exam,
                EntityId: this.ExamId
            }, response => {
                //this.saveOrder(exam.Id);
                Q.confirm('New Exam with ID:  is created. Would you like to add another one?', () => {
                    this.reset();
                }, {
                    onNo: () => this.dialogClose(),
                    onCancel: () => this.dialogClose(),
                    onClose: () => this.dialogClose()
                });

            });

        }

        /**
         * will be called by finish method to save order with an existing customer ID,
         * or a newly created one 
         * @param ExamID
         */
        protected saveOrder(ExamID: number) {
            //var order = this.getSaveEntity([
            //    OrderWizardSteps.ExamSections,
            //    OrderWizardSteps.ExamQuestions,
            //]);
            //order.Id = ExamID;
            //debugger;
            //order.ExamSections.forEach(function (section) {
            //    section.ExamId = ExamID;
            //    // in case the input is already filled..
            //    ExamSectionService.Create({
            //        Entity: section
            //    }, response => {

            //    });
            //});


        }
    }

    // we define this enum to avoid magic step numbers
    export enum ExamWizardSteps {
        ExamDetails = 1,
        ExamSections = 2,
        ExamQuestions = 3
    }
}