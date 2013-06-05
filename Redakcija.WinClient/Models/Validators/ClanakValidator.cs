using FluentValidation;

namespace Redakcija.WinClient.Models.Validators
{
    public class ClanakValidator : AbstractValidator<Clanak>
    {
        public ClanakValidator()
        {
            RuleFor(x => x.Naslov).NotEmpty().WithMessage("Naslov nije unet");
            RuleFor(x => x.PublikacijaID).NotNull().WithMessage("Publikacija nije izabrana");
            RuleFor(x => x.RubrikaID).NotNull().WithMessage("Rubrika nije izabrana");
        }
    }
}