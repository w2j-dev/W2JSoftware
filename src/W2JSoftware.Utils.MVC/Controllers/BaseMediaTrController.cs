using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using W2JSoftware.Utils.Logging;
using W2JSoftware.Utils.WebBase.Controllers;

namespace W2JSoftware.Utils.MVC.Controllers
{
    /// <summary>
    /// The Controller using the MediaTR 
    /// When using Mediator Pattern with MediaTR
    /// The Razors Page need to inherit this class
    /// </summary>
    /// <seealso cref="W2JSoftware.Utils.REST.Controller.ResponseBaseController" />
    public class BaseMediaTrController : ResponseBaseController
    {
        /// <summary>
        /// The logger configuration
        /// </summary>
        private LoggerConfig _loggerConfig;

        /// <summary>
        /// The mediator
        /// </summary>
        private IMediator _mediator;

        /// <summary>
        /// Gets the logger configuration.
        /// </summary>
        /// <value>
        /// The logger configuration.
        /// </value>
        protected LoggerConfig LoggerConfig =>
            _loggerConfig ??= HttpContext.RequestServices.GetService<Func<object, LoggerConfig>>()(this);

        /// <summary>
        /// Gets the mediator.
        /// </summary>
        /// <value>
        /// The mediator.
        /// </value>
        protected IMediator Mediator =>
            _mediator ??= HttpContextAccessor.HttpContext.RequestServices.GetService<IMediator>();
    }
}
