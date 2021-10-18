namespace Selenium
{
    public class Config
    {
        public class Credentials
        {
            public class Valid
            {
                public static string UserName = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public class Invalid
            {
                public class UserName
                {
                    public static string FourCharacter = "abcd";
                    public static string ThirteenCharacter = "abcdefacdascd";
                }
                
            }
        }
    }
}