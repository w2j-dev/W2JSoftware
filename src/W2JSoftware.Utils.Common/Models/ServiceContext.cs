using W2JSoftware.Utils.Common.Interfaces;

namespace W2JSoftware.Utils.Common.Models
{
    /// <summary>
    /// Context of Service, used on logger and others
    /// </summary>
    /// <seealso cref="W2JSoftware.Utils.Common.Interfaces.IServiceContext" />
    public class ServiceContext : IServiceContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext"/> class.
        /// </summary>
        public ServiceContext()
        {

        }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        /// <value>
        /// The operation.
        /// </value>
        public string Operation { get; set; }
    }
}