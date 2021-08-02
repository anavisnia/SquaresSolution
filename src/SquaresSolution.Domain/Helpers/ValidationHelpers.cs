using FluentValidation.Results;
using System.Collections.Generic;

namespace SquaresSolution.Domain.Helpers
{
    public static class ValidationHelpers
    {
        public static string GenerateErrorMessage(IEnumerable<ValidationFailure> validationFailures)
        {
            var errors = "";

            foreach (var error in validationFailures)
            {
                errors += error.ToString() + "\n";
            }

            return errors;
        }
    }
}
