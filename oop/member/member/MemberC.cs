using System;
namespace member
{
    public class MemberC
    {
        private string memberName;
        private string jobtitle;
        private int salary = 20000;

        public int age;

        //member -property
        public string jobTitle
        {
            get
            {

                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfor();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfor()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member construcotr
        public MemberC()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            Console.WriteLine("Object created");
        }

        //member - destructor
        ~MemberC()
        {
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}

