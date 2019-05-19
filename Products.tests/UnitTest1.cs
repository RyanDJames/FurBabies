using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Products.tests
{
    [TestClass]
    public class UnitTest1
    {

        private IReservationHelper getTestObject()
        {
            return new ReservationHelper();
        }
        [TestMethod]
        public void Reservation_beyond_180()
        {
            IReservationHelper target = getTestObject();
            int total = 180;


            var daysAwayTotal = target.ScheduleReservation(daysAwayTotal);

            Assert.AreEqual(daysAwayTotal > 180, days)
           
        }
    }
}
