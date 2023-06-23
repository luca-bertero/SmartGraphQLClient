﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartGraphQLClient.Tests.TestsInfrastructure;

namespace SmartGraphQLClient.Tests.Core.GraphQLHttpClient
{
    [TestClass]
    public partial class GraphQLHttpClientTests : TestBase
    {
        private SmartGraphQLClient.GraphQLHttpClient CreateClient()
            => ServiceProvider.GetRequiredService<TestGraphQLHttpClient>();
        private SmartGraphQLClient.GraphQLHttpClient CreateAuthorizedClient()
            => ServiceProvider.GetRequiredService<AuthorizedTestGraphQLHttpClient>();
        private SmartGraphQLClient.GraphQLHttpClient CreateAuthorizedClientWithAuthorizationService()
            => ServiceProvider.GetRequiredService<AuthorizedWithRenewTokenGraphQLHttpClient>();
    }
}
