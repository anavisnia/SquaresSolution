using FluentValidation;
using SquaresSolution.Domain.Entities;

namespace SquaresSolution.Domain.Validators
{
    public class CoordinateValidator : AbstractValidator<PointEntity>
    {
        public CoordinateValidator()
        {
            RuleFor(x => x.X).InclusiveBetween(-5000, 5000);
            RuleFor(x => x.Y).InclusiveBetween(-5000, 5000);
        }
    }
}
