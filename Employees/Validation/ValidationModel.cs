using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Employees.Validation
{
    public static class ValidationModel
    {
        public static bool TryValidate(Employee employee)
        {
            bool resultValidation = false;
            if (employee != null)
            {
                ValidationContext context = new ValidationContext(employee, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(employee, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resultValidation = false;
                    }
                }
                else resultValidation = true;
            }
            else resultValidation = false;
            return resultValidation;
        }
    }
}