using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.QuestionBank
{
    [NestedPermissionKeys]
    [DisplayName("QuestionBank")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "QuestionBank:General";

        [DisplayName("QuestionBank Management")]
        public class QuestionBankManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "QuestionBank:QuestionBankManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "QuestionBank:QuestionBankManagement:Modify";
            public const string View = "QuestionBank:QuestionBankManagement:View";
        }
        
        
    }
}