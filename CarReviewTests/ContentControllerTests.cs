using CarContent.Controllers;
using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace CarReviewTests
{
    public class ContentControllerTests
    {
        private ContentController underTest;
        IRepository<Content> contentRepo;

        public ContentControllerTests()
        {
            contentRepo = Substitute.For<IRepository<Content>>();
            underTest = new ContentController(contentRepo);
        }

        [Fact]
        public void Index_Returns_View()
        {

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_Model_to_View()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Create_Returns_a_ViewResult()
        {
            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Post_Returns_ActionResult()
        {
            var result = underTest.Create(new Content());

            Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Update_Returns_a_ViewResult()
        {
            var result = underTest.Update(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Post_Returns_ActionResult()
        {
            var result = underTest.Update(new Content());

            Assert.IsAssignableFrom<ActionResult>(result);
        }

    }
}
