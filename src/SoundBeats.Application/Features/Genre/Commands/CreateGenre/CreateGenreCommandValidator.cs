using FluentValidation;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Genre.Commands
{
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreDTO>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} property value is required.")
               .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");
        }
    }
}
