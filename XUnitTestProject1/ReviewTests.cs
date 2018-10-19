using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewTests
    {
        [Fact]
        public void GetAll_Returns_3_Reviews()
        {
            var underTest = new ReviewRepository();

            var result = underTest.GetAll();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void FindById_Returns_Correct_Review()
        {
            var underTest = new ReviewRepository();

            var result = underTest.FindById(2);

            Assert.Equal(2, result.Id);
            //Assert.Equal("Moana", result.Name);
        }
    }
}
