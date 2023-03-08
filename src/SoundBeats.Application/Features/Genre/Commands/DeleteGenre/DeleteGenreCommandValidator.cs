using FluentValidation;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Genre.Commands
{
    public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreDTO>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.");
        }

    }
}
