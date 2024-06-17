namespace WPC.SOLID.SRP
{
        public class User
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }

        public class Validators
        {
            public bool ValidateEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }
        }

        /*public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public bool ValidateEmail()
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(Email);
            return addr.Address == Email;
        }
        catch
        {
            return false;
        }
    }
}*/
}
