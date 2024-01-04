using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExampleController : ControllerBase
    {
        #region Constructors

        public ExampleController(ILoggerFactory loggerFactory)
        {
            this.Logger = (loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory))).CreateLogger(this.GetType());
        }

        #endregion

        #region Properties

        protected internal virtual ILogger Logger { get; }

        #endregion

        #region Methods

        [HttpGet]
        public virtual string Get()
        {
            this.Logger.LogDebug("Get");

            return "Value";
        }

        #endregion
    }
}