using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Swagger.Test.Models;
using Swagger.Test.Services.Interfaces;

namespace Swagger.Test.Services
{
    public class ApplicationSystemService : IApplicationSystemService
    {
        IEnumerable<ApplicationSystemPerformance> IApplicationSystemService.GetPerformance()
        {
            ApplicationSystemPerformance telegram = new ApplicationSystemPerformance(6, "Telegram(54456)", true);
            ApplicationSystemPerformance microsoft = new ApplicationSystemPerformance(5, "Microsoft Debug Console");
            ApplicationSystemPerformance chrome = new ApplicationSystemPerformance(4, "Chrome");

            return new List<ApplicationSystemPerformance>()
            {
                telegram, microsoft, chrome
            };
        }

        IEnumerable<ApplicationSystemDefinition> IApplicationSystemService.GetDefinition()
        {
            ApplicationSystemDefinition telegramDef = new ApplicationSystemDefinition(3, "8", "114");
            ApplicationSystemDefinition microsoftDef = new ApplicationSystemDefinition(2, "10", "32");
            ApplicationSystemDefinition chromeDef = new ApplicationSystemDefinition(1, "4", "16");

            return new List<ApplicationSystemDefinition>()
            {
                telegramDef, microsoftDef, chromeDef
            };
        }
    }
}