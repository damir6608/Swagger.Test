using Swagger.Test.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swagger.Test.Services.Interfaces
{
    public interface IApplicationSystemService
    {
        public IEnumerable<ApplicationSystemPerformance> GetPerformance();

        public IEnumerable<ApplicationSystemDefinition> GetDefinition();
    }
}
