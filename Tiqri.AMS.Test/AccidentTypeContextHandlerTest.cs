using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tiqri.AMS.BizObject;
using System.Collections.Generic;
using Tiqri.AMS.Model;
using Tiqri.AMS.Web.ContextHandlers;

namespace Tiqri.AMS.Test
{
    [TestClass]
    public class AccidentTypeContextHandlerTest
    {
        [TestMethod]
        public void AccidentType_ReturnViewModelTest()
        {
            var mock = new Mock<IAccidentCategoryBiz>();
            mock.Setup(f => f.GetAccidentCategoryList()).Returns(
                new List<AccidentCategory>() {
                    new AccidentCategory() { ID=1, Name= "Accident with Injury" },
                    new AccidentCategory() { ID=1, Name= "Dangerous Occurence" }
                });

            IAccidentTypeContextHandler context = new AccidentTypeContextHandler(mock.Object);
            var list = context.GetAccidentCategoryList();

            Assert.AreEqual(2, list.Count);
            ///

        }
    }
}
