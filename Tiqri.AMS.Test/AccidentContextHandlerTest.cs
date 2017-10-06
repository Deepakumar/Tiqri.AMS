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
            mock = GetAccidentMockObject();
            context = new AccidentContextHandler(mock.Object);
            var list = context.QueryAccident();

            Assert.AreEqual(2, list.Count);

        }

        [TestMethod]
        public void Query_Accident_LocationTypeName()
        {
            mock = GetAccidentMockObject();
            context = new AccidentContextHandler(mock.Object);

            var list = context.QueryAccident();

            Assert.AreEqual("AtThesePremises", list[0].Location.ToString());

        }

        public void Create_Accident_Test()
        {
            Accident accidentOut=null;
            var mock = new Mock<IAccidentBiz>();
            mock.Setup(m => m.CreateAccident(It.IsAny<Accident>()))
            .Returns((Accident acci) => {
                accidentOut = acci;
                return true;
            });

            Web.ViewModel.Accident accidentIn = new Tiqri.AMS.Web.ViewModel.Accident()
            {
                ReportedId = "A34rfrt678",
                CategoryId =1,
                LocationTypeId =1,
                History ="History",
                Date ="05/05/2017",
                Time = "10:05 AM"
            };
            context = new AccidentContextHandler(mock.Object);
            context.CreateAccident(accidentIn);

            Assert.AreEqual(accidentIn.ReportedId, accidentOut.ReporterID);

        }

        private Mock<IAccidentBiz> GetAccidentMockObject()
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

            

            return mock;
        }
    }
}
