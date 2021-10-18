namespace Selenium
{
    public class Config
    {
        public static string BaseUrl = "http://testing.todorvachev.com/";

        public class Credentials
        {
            public class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public class Invalid
            {
                public class Username
                {
                    public static string FourCharacter = "abcd";
                    public static string ThirteenCharacter = "abcdefacdascd";
                }

                public class Password
                {
                    public static string FourCharacter = "abcd";
                    public static string ThirteenCharacter = "abcdefacdascd";
                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
        }
    }
}