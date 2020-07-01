using CarReview.Controllers;
using CarReview.Models;
using CarReview.Repository;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarReviewTests
{
    public class CategoryControllerTests
    {
            CategoryController underTest;
            IRepository<Category> categoryRepo;
        
            public CategoryControllerTests()
            {
                categoryRepo = Substitute.For<IRepository<Category>>();
                underTest = new CategoryController(categoryRepo);
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
                var result = underTest.Create(new Category());

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
            var result = underTest.Update(new Category());

            Assert.IsAssignableFrom<ActionResult>(result);
        }
    }
}
