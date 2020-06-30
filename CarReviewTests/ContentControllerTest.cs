using CarContent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace CarReviewTests
{
    public class ContentControllerTest

    {
        ContentController underTest;
        [Fact]
        public void Index_Returns_A_View()
        {

            var underTest = new ContentController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
        public void Details_Returns_A_View()
        {
            var underTest = new ContentController();

            var result = underTest.Details();

            Assert.IsType<ViewResult>(result);
        }

    }
}
