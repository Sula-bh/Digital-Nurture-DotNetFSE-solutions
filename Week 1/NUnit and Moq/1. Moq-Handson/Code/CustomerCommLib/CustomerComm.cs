namespace CustomerCommLib
{

    public class CustomerComm
    {
        private readonly IMailSender mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            this.mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            string email = "cust123@abc.com";

            string message = "Some Message";

            mailSender.SendMail(email, message);

            return true;
        }
    }
}