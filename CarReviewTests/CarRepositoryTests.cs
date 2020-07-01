using CarReview.Models;
using CarReview.Repository;
using CarReview.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarReviewTests
{
    public class CarRepositoryTests : IDisposable
    {
        private CarBlogContext db;
        private CarRepository underTest;

        public CarRepositoryTests()
        {
            db = new CarBlogContext();
            db.Database.BeginTransaction();
            underTest = new CarRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
        [Fact]
        public void Count_Starts_At_Ten()
        {
            var count = underTest.Count();
            Assert.Equal(10, count);
        }
        [Fact]
        public void Create_Increases_Count_By_1()
        {
            var currCount = underTest.Count();
            underTest.Create(new Content() { Author = "name", Body = "test", CategoryId = 2 });
            var count = underTest.Count();
            Assert.Equal(currCount + 1, count);
        }
        [Fact]
        public void Delete_Decreases_Count_By_1()
        {
            var startCount = underTest.Count();
            Content testContent = new Content() { Author = "name", Body = "test", CategoryId = 2 };
            underTest.Create(testContent);
            underTest.Delete(testContent);
            var endCount = underTest.Count();
            Assert.Equal(startCount, endCount);
        }

        [Fact]
        public void Update_Changes_Property()
        {
            Content testContent = new Content() { Author = "name", Body = "test", CategoryId = 2 };
            underTest.Update(testContent);
        }

        [Fact]
        public void GetAll_Should_Return_AllContents()
        {
            underTest.GetAll();
            Assert.NotNull(db.Contents);
        }

        [Fact]
        public void GetbyId_Should_Return_Selected_Content()
        {
            
            Content expectedContent = underTest.GetById(1);
            Assert.Equal("Steve Jobs", expectedContent.Author);
        }
    }
}
