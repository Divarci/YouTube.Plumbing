namespace ServiceLayer.Messages.WebApplication
{
    public static class NotificationMessagesWebApplication
    {
        private const string BaseAddMessage = " has been saved!!";
        private const string BaseUpdateMessage = " has been updated!!";
        private const string BaseDeleteMessage = " has been deleted!!";

        public const string SuccessedTitle = "Congratulations!!";
        public const string FailedTitle = "I am sorry!!";

        public static string AddMessage(string subject) => subject + BaseAddMessage;
        public static string UpdateMessage(string subject) => subject + BaseUpdateMessage;
        public static string DeleteMessage(string subject) => subject + BaseDeleteMessage;

    }
}
