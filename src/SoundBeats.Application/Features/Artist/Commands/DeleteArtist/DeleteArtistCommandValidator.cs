using FluentValidation;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Features.Artist.Commands
{
    public class DeleteArtistCommandValidator : AbstractValidator<DeleteArtistDTO>
    {
        public DeleteArtistCommandValidator()
        {
            RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("You must chose a {PropertyName}.")
                .GreaterThan(0).WithMessage("The {PropertyName} index should be greater than 0.");
        }
    }
}
