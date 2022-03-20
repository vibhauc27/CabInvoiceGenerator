using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        //Invoice generator reference
        InvoiceGenerator invoiceGenerator = null;

        [Test]  //Test case to check calculate fare function
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Creating instance of invoice for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            //Calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            //Assert
            Assert.AreEqual(expected, fare);
        }
    }
}