using Data.Entities;
using FluentValidation;

namespace Data.FluentValidation
{
    public class AnnoucementValidation : AbstractValidator<Announcement>
    {
        public AnnoucementValidation()
        {
            RuleFor(announcement => announcement.Title).NotEmpty().Length(1, 55);
            RuleFor(announcement => announcement.Description).NotEmpty().Length(1, 5000);
            RuleFor(announcement => announcement.DateAdded).NotNull();
        }
    }
}
