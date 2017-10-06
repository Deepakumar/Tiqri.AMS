using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tiqri.AMS.BizObject.Impl;
using Moq;
using Tiqri.AMS.Model;
using System.Collections.Generic;
using Tiqri.AMS.Web.ContextHandlers;
using Tiqri.AMS.Web.ContextHandlers.impl;

namespace Tiqri.AMS.Test
{


    [TestClass]
    public class AccidentContextHandlerTest
    {
        IAccidentContextHandler context;
        Mock<IAccidentBiz> mock;

        [TestMethod]
        public void Query_Accidents_NoOfRecords()
        {
            var mock = new Mock<IAccidentBiz>();
            mock.Setup(f => f.QueryAccident()).Returns(
                new List<Accident>() {
                    new Accident() {
                        ID =1,
                        ReferenceNo ="ACD00001",
                        AccidentDate = DateTime.Today.AddDays(-30),
                        TypeOfLocation = Model.Enum.TypeOfLocation.AtThesePremises,
                        ReporterID = "a345ssfsfs"
                    },
                    new Accident() { ID =1,
                        ReferenceNo ="ACD00002",
                        AccidentDate = DateTime.Today.AddDays(-30),
                        TypeOfLocation = Model.Enum.TypeOfLocation.AtThesePremises,
                        ReporterID = "a345ssfsfs"  }
                });


            context = new AccidentContextHandler(mock.Object);
            var list = context.QueryAccident();

            Assert.AreEqual(2, list.Count);

        }
    }
}
