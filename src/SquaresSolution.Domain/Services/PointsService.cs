using SquaresSolution.Domain.Entities;
using SquaresSolution.Domain.Exceptions;
using SquaresSolution.Domain.Helpers;
using SquaresSolution.Domain.Interfaces;
using SquaresSolution.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SquaresSolution.Domain.Services
{
    public class PointsService
    {
        private IPointsRepository _repository;

        public PointsService(IPointsRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<PointEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task AddPointAsync(PointEntity point)
        {
            var validator = new CoordinateValidator();

            var validationResult = await validator.ValidateAsync(point);

            if (!validationResult.IsValid)
            {
                throw new CustomValidationException(
                    ValidationHelpers.GenerateErrorMessage(validationResult.Errors)
                    );
            }

            await _repository.AddPoint(point);
        }
    }
}
