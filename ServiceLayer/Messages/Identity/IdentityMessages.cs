namespace ServiceLayer.Messages.Identity
{
    public static class IdentityMessages
    {
        public const string SecurityStampError = "Your critical information has been changed. Please try to login again";

        public static string CheckEmailAddress()
        {
            return "Value should be in email format!";
        }

        public static string ComparePassword()
        {
            return "Password and Confirm Password must be same!";
        }

       
    }
}
