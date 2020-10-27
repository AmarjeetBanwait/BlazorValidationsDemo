using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Forms;

namespace BlazorValidationsDemo.Helpers
{
    public class BsFieldClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier _fieldIdentifier)
        {
            bool isValid = !editContext.GetValidationMessages(_fieldIdentifier).Any();

            bool isModified = editContext.IsModified(_fieldIdentifier);

            if (isModified)
            {
                return isValid ? "modified is-valid" : "modified is-invalid";
            }
            else
            {
                return isValid ? "is-valid" : "is-invalid";
            }
        }

        

    }
    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }

}
