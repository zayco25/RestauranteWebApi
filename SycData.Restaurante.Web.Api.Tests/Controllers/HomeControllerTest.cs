using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SycData.Restaurante.Web.Api;
using SycData.Restaurante.Web.Api.Controllers;

namespace SycData.Restaurante.Web.Api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
