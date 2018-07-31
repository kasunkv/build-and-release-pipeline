using BuildAndRelease.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace BuildAndRelease.Web.Tests
{
    public class HomeControllerShould
    {
        private readonly HomeController _controller;

        public HomeControllerShould()
        {
            _controller = new HomeController();
        }

        [Fact]
        public void ReturnViewWhenIndexIsCalled()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ReturnViewWhenAboutIsCalled()
        {
            var about = _controller.About();
            Assert.IsType<ViewResult>(about);
        }

        [Fact]
        public void ReturnViewWhenContractIsCalled()
        {
            var contact = _controller.Contact();
            Assert.IsType<ViewResult>(contact);
        }

        [Fact]
        public void ReturnViewWhenPrivacyIsCalled()
        {
            var privacy = _controller.Privacy();
            Assert.IsType<ViewResult>(privacy);
        }
    }

}
