using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swagger.Test.Models;
using Swagger.Test.Services;
using Swagger.Test.Services.Interfaces;

namespace Swagger.Test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationSystemController : ControllerBase
    {
        private readonly IApplicationSystemService _applicationSystemService;

        public ApplicationSystemController(IApplicationSystemService applicationSystemService)
        {
            _applicationSystemService = applicationSystemService;
        }

        /// <summary>
        /// Returns all running applications available on the device
        /// </summary>
        /// <returns><see cref="List{ApplicationSystemPerformance}"/></returns>
        [Route("performance")]
        [HttpGet]
        public ActionResult<IEnumerable<ApplicationSystemPerformance>> GetPerformance()
        {
            return Ok(_applicationSystemService.GetPerformance());
        }

        /// <summary>
        /// Returns all available application load characteristics
        /// </summary>
        /// <returns><see cref="List{ApplicationSystemDefinition}"/></returns>
        [Route("definition")]
        [HttpGet]
        public ActionResult<IEnumerable<ApplicationSystemDefinition>> GetDefinition()
        {
            return Ok(_applicationSystemService.GetDefinition());
        }

        /// <summary>
        /// Returns an application with an existing MainWindowTitle
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [Route("performance/{title}")]
        [HttpGet]
        public ActionResult<ApplicationSystemPerformance> GetPerformanceByTitle(string title)
        {
            return Ok(_applicationSystemService.GetPerformance().FirstOrDefault(perf => string.Equals(perf.MainWindowTitle, title)));
        }

        /// <summary>
        /// Returns the application with the specified process priority parameter
        /// </summary>
        /// <param name="processPriority">Process priority</param>
        [Route("definition/{processPriority}")]
        [HttpGet]
        public ActionResult<ApplicationSystemDefinition> GetDefinitionByProcessPriority(string processPriority)
        {
            return Ok(_applicationSystemService.GetDefinition().FirstOrDefault(def => string.Equals(def.ProcessPriority, processPriority)));
        }
    }
}