using Xunit;
using Bunit;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Bunit.Rendering;

namespace Bunit.Docs.Samples
{
  public class ChildContentParams3Test
  {
    [Fact]
    public void Test()
    {
      using var ctx = new TestContext();

      var cut = ctx.RenderComponent<ChildContentParams>(parameters => parameters
        .AddChildContent<Alert>(alertParameters => alertParameters
          .Add(p => p.Heading, "Alert heading")
          .Add(p => p.Type, AlertType.Warning)
          .AddChildContent("<p>Hello World</p>")
        )
      );
    }
  }
}