using ApplicationCore.Interfaces;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingControllersSample.Controllers;
using Xunit;

namespace TestingControllersSample.Tests
{
    public class HomeControllerTests
    {

        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfProducts()
        {
             // Arrange
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(x=>x.GetAll()).Returns(GetTestProducts());
            var controller = new HomeController(mockRepo.Object);
            // Act
            var result = controller.Index();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Products>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }
        #region snippet_GetTestProducts
        private List<Products> GetTestProducts()
        {
            var products = new List<Products>();
            products.Add(new Products()
            {
                ProductName = "Test 1"
            });
            products.Add(new Products()
            {
                ProductName = "Test 2"
            });
            return products;
        }
        #endregion
    }
}
