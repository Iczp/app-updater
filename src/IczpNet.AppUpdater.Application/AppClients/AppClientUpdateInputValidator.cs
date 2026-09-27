using FluentValidation;
using IczpNet.AppUpdater.Localization;
using IczpNet.AppUpdater.AppClients;
using Microsoft.Extensions.Localization;

namespace IczpNet.AppUpdater.AppClients;

public class AppClientUpdateInputValidator : AbstractValidator<AppClientUpdateInput>
{
    public AppClientUpdateInputValidator(IStringLocalizer<AppUpdaterResource> _localizer)
    {

        //RuleFor(x => x.Name)
        //   .NotEmpty()
        //   .WithMessage(_localizer["AppUpdater"]);
    }
}
