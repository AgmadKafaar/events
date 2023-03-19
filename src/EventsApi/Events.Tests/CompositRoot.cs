using Microsoft.Extensions.DependencyInjection;

namespace Events.Tests
{
    /// <summary>
    /// The composit root class
    /// </summary>
    public class CompositRoot
    {
        /// <summary>
        /// The service provider
        /// </summary>
        private readonly ServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositRoot"/> class
        /// </summary>
        public CompositRoot()
        {
            var services = new ServiceCollection();
            _serviceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// Gets the service
        /// </summary>
        /// <typeparam name="TService">The service</typeparam>
        /// <returns>The service</returns>
        public TService GetService<TService>()
        {
            return _serviceProvider.GetService<TService>();
        }
    }
}