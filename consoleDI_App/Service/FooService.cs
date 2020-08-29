using consoleDI_App.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace consoleDI_App.Service
{
    class FooService : IFooService
    {
        private readonly ILogger<FooService> _logger;
        public FooService(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FooService>();
        }

        public void DoThing(int number)
        {
            _logger.LogInformation($"Doing the thing {number}");
        }
    }
}
