using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // copy and paste code from section below to test how it works
            new TestService().Start();
            StaticClass.Method1(1);
            Console.ReadKey();
        }

        private static void ValueExample(int x)
        {
            x += 5;
            Console.WriteLine(x);
        }

        private static void ReferenceExample(ref int x)
        {
            x += 5;
            Console.WriteLine(x);
        }

        private static void TableExample(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= 2;
            }
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }

        private static void DeclaringVariablesAndConsts()
        {
            int counter = 0;
            string text = "I like C# :)";
            double value = 69.96;
            decimal actualBitcoinRate = 58051.7952m;

            const string youCantChangeMe = "hahahaha";
        }

        private static void SingleAndMultiLineComments()
        {
            // this is single line comment

            /* this 
             * is
             * multi
             * line
             * comment
             */
        }

        private static void StandardTypes()
        {
            char singleCharacter = 'a';
            string text = "I like C# :)";
            int counter = 0;
            double value = 69.96;
            decimal actualBitcoinRate = 58051.7952m;
            bool isItTrue = false;

            int numberOfElementsInArray = 5;
            int[] arrayOfNumbers = new int[numberOfElementsInArray];
            arrayOfNumbers[0] = 1;
            arrayOfNumbers[1] = 2;
            arrayOfNumbers[2] = 3;
            arrayOfNumbers[3] = 4;
            arrayOfNumbers[4] = 5;

            string thisIsAwesome = text + ", more than my chef :).";
            string howToStringWorks = actualBitcoinRate.ToString() + " - this is actual rate of bitcoin.";
        }

        private static void ArithmeticOperators()
        {
            int firstValue = 5;
            int secondValue = 10;

            int sum = firstValue + secondValue;
            int diff = secondValue - firstValue;
            int multiplying = firstValue * secondValue;
            int quotient = secondValue / firstValue;

            double valueInDifferentType = 2.5;
            // you can't do this because of different types
            // int result = secondValue / valueInDifferentType;

            int modulo = secondValue % firstValue;


            int firstResult = 1;
            firstResult += 1;

            int secoundResult = 2;
            secoundResult -= 5;

            int thirdResult = 10;
            thirdResult *= 2;

            int fourthResult = 50;
            fourthResult /= 23;
            // what is the result of fourthResult

            firstResult++;
            ++firstResult;

            secoundResult--;
            --secoundResult;
        }

        private static void LogicOperators()
        {
            // 5 > 10     10 < 11
            // 5 >= 5     20 <= 200
            // 10 == 20   100 != 50
        }

        private static void HowIfWorks()
        {
            int firstValue = 5;
            int secondValue = 10;
            bool isFirstValueBiggerThanSecond;
            bool orMaybyValesAreSame = false;

            if (firstValue > secondValue)
            {
                isFirstValueBiggerThanSecond = true;
            }
            else
            {
                isFirstValueBiggerThanSecond = false;
            }

            if (firstValue > secondValue)
            {
                isFirstValueBiggerThanSecond = true;
            }
            else if (firstValue == secondValue)
            {
                orMaybyValesAreSame = true;
            }
            else
            {
                isFirstValueBiggerThanSecond = false;
            }
        }

        private static void HowSwitchWorks()
        {
            string caseText = "first";
            //string caseText = "second";
            //string caseText = "third";
            //string caseText = "default";

            switch (caseText)
            {
                case "first":
                    break;
                case "second":
                    break;
                case "third":
                    break;
                default:
                    break;
            }
        }

        private static void HowForWorks()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
        }

        private static void HowForWhileWorks()
        {
            int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum += i;
                i++;
            }
        }

        private static void HowForDoWhileWorks()
        {
            int i = 1;
            int sum = 0;
            bool canIContinue = false;

            do
            {
                sum += i;
            } while (canIContinue == true);
        }

        private static void TernaryOperator()
        {
            int firstValue = 5;
            int secondValue = 10;
            bool isFirstValueBigger = firstValue > secondValue ? true : false;
        }
    }
}
