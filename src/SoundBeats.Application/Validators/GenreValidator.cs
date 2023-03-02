﻿using FluentValidation;
using SoundBeats.Core.DTO;

namespace SoundBeats.Application.Validators
{
    public class GenreValidator : AbstractValidator<GenreDTO>
    {
        public GenreValidator()
        {
            RuleFor(u => u.Name).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El nombre de Género es necesario.")
                .Length(3,50).WithMessage("Debe tener una longitud entre {MinLength} y {MaxLength} caracteres.");
        }
    }
}
