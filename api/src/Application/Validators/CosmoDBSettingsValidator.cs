using Aeveco.CampaignFinance.Domain.Configuration;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Application.Validators
{
    public class CosmoDBSettingsValidator : AbstractValidator<CosmoDBSettings>
    {
        public CosmoDBSettingsValidator()
        {
            RuleFor(x => x.AccountEndPoint).NotEmpty();
            RuleFor(x => x.AccountKey).NotEmpty();
            RuleFor(x => x.DatabaseName).NotEmpty();
        }
    }
}
