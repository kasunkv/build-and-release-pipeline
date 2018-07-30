using BuildAndRelease.Web.Controllers;
using System;
using Xunit;

namespace BuildAndRelease.Web.Tests
{
    public class HomeControllerShould
    {
        [Fact]
        public void ReturnViewWhenIndexIsCalled()
        {
            var controller = new HomeController();
            var index = controller.Index();
            Assert.NotNull(index);
        }
    }
}
