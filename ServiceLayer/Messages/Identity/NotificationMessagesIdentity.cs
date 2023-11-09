namespace ServiceLayer.Messages.Identity
{
    public static class NotificationMessagesIdentity
    {
        private const string UserEditSuccess = " has been Updated!!";
        private const string SignUpSuccess = " has been Created!!";

        public const string LogInSuccess = "You have logged In. Please have fun.";
        public const string PasswordResetSuccess = "Your password reset link has been sent to your email address.";
        public const string TokenValidationError = "Your token is no more valid. Please try again";
        public const string UserError = "User does not exist!!";
        public const string PasswordChangeSuccess = "Your password has been changed. Please try to LogIn.";

        public const string SuccessedTitle = "Congratulations!!";
        public const string FailedTitle = "I am sorry!!";

        public const string ExtendClaimSuccess = "User has 5 more days!!";
        public const string ExtendClaimFailed = "User extend method is failed!!";

        public static string SignUp(string userName) => userName + SignUpSuccess;
        public static string UserEdit(string userName) => userName + UserEditSuccess;



    }
}
