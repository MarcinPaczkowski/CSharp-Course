using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate<string> firstPredicate = FirstPredicate;
            //firstPredicate("0");

            //Func<int, string, bool, string> firstFunc = FirstFunc;
            //firstFunc(1, "x", true);

            //Action<int, string> firtAction = FirtAction;


            //Predicate<int> secondPredicate = (i) =>
            //{
            //    var x = 1;

            //    return true;
            //};

            //secondPredicate(1);

            //GetAsPredicate(FirstPredicate);
            //GetAsAction(FirtAction);

            var users = new List<User<int>>
            {
                new User<int>
                {
                    Email = "test1@test.pl",
                    Id = 1,
                    Name = "test1"
                },
                new User<int>
                {
                    Email = "test2@test.pl",
                    Id = 2,
                    Name = "test2"
                },
                new User<int>
                {
                    Email = "test3@test.pl",
                    Id =3,
                    Name = "test3"
                }
            };

            var user = users.Find(u => u.Id == 2);

            var usersEmails = users.Select(u => u.Email).ToList();

            Console.ReadKey();
        }

        private static void GetAsPredicate(Predicate<string> predicate)
        {
            var x = 1;
            bool isBigger;
            if (x > 1) isBigger = true;
            else isBigger = false;

            predicate("ssxxs");
        }

        private static void GetAsAction(Action<int, string> action)
        {
            throw new NotImplementedException();
        }

        private static void FirtAction(int i, string x)
        {
            throw new NotImplementedException();
        }

        private static string FirstFunc(int i, string x, bool y)
        {
            throw new NotImplementedException();
        }

        private static bool FirstPredicate(string x)
        {
            return x.Equals("0");
        }
    }
}
