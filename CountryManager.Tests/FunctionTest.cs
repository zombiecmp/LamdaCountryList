using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using CountryManager;
using Amazon.Lambda.APIGatewayEvents;

namespace CountryManager.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestGetCountriesFunction()
        {
            var request = new APIGatewayProxyRequest();

            var function = new Function();
            var context = new TestLambdaContext();
            var response = function.Get(request, context);

            Assert.Equal(200, response.StatusCode);
        }
    }
}
