﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using W2JSoftware.Utils.Logging;

namespace W2JSoftware.Utils.WebBase.Controllers
{
    /// <summary>
    /// The Controller that inherit the ResponseBaseController
    /// When create controllers, it should inherit from this.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public abstract class BaseController : ResponseBaseController
    {
        /// <summary>
        /// The logger configuration
        /// </summary>
        private LoggerConfig _loggerConfig;


        /// <summary>
        /// The mapper
        /// </summary>
        private IMapper _mapper;

        /// <summary>
        /// Gets the logger configuration.
        /// </summary>
        /// <value>
        /// The logger configuration.
        /// </value>
        protected LoggerConfig LoggerConfig =>
            _loggerConfig ??= HttpContextAccessor.HttpContext.RequestServices.GetService<Func<object, LoggerConfig>>()(this);

        /// <summary>
        /// Gets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        protected IMapper Mapper => _mapper ??= HttpContextAccessor.HttpContext.RequestServices.GetService<IMapper>();

    }
}
