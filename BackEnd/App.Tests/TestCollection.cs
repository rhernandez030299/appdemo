﻿using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace App.Tests
{
    // dotnet add ./BackEnd/App.Tests/App.Tests.csproj reference ./BackEnd/App.Api/App.Api.csproj
    [CollectionDefinition("Tests de Integración", DisableParallelization = true)]
    public class TestCollection : ICollectionFixture<WebApplicationFactory<App.Api.Startup>>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
