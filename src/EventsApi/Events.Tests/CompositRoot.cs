using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Events.Tests
{
    public class CompositRoot
    {

        private readonly ServiceProvider _serviceProvider;

        public CompositRoot()
        {
            var services = new ServiceCollection();
            _serviceProvider = services.BuildServiceProvider();
        }

        public TService GetService<TService>()
        {
            return _serviceProvider.GetService<TService>();
        }
    }
}
