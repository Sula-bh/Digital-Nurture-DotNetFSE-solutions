using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerComm.Tests
{

    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;

        private CustomerCommLib.CustomerComm customerComm;

        [OneTimeSetUp]
        public void Setup()
        {
            mockMailSender =
                new Mock<IMailSender>();

            customerComm =
                new CustomerCommLib.CustomerComm(
                    mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            mockMailSender
                .Setup(m =>
                    m.SendMail(
                        It.IsAny<string>(),
                        It.IsAny<string>()))
                .Returns(true);

            bool result =
                customerComm.SendMailToCustomer();

            Assert.That(result,
                Is.True);
        }
    }
}