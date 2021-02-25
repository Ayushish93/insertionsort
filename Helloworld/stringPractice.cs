using System;
namespace Helloworld
{
    public class stringPractice
    {
        public string display()
        {
            var firstName = "Ayushi";
            var lastName = "Sharma";
            var fullName = string.Format("{0} {1}", firstName, lastName);
            return fullName;
        }
    }
}
