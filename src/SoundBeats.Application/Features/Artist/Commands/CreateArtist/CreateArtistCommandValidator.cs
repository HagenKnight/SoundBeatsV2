using FluentValidation;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Artist.Commands
{
    public  class CreateArtistCommandValidator : AbstractValidator<CreateArtistDTO>
    {
        public CreateArtistCommandValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(3, 50).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length.");

            RuleFor(u => u.Biography).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} property value is required.")
                .Length(5, 5000).WithMessage("{PropertyName} property should be between {MinLength} and {MaxLength} characters in length..");

            RuleFor(u => u.CountryId)
                .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");
        }
    }
}
