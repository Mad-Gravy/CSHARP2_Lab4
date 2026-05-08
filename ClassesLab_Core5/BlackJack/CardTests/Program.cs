using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Running all the tests!
            TestCardConstructors();
            TestCardToString();
            TestCardPropertyGetters();
            TestCardPropertySetters();
            TestCardMatchingMethods();
            TestCardColorMethods();
            TestCardValueMethods();
            Console.WriteLine("All tests complete!");
            Console.ReadLine();
        }


        // Test constructors!
        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(1, 1);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor. Expecting random values. " + c1.ToString());
            Console.WriteLine("Overloaded constructor. Expecting Ace of Clubs. " + c2.ToString());
            Console.WriteLine();
        }


        // Test ToString!
        static void TestCardToString()
        {
            Card c1 = new Card(1, 1);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting Ace of Clubs. " + c1.ToString());
            Console.WriteLine("Expecting Ace of Clubs. " + c1);
            Console.WriteLine();
        }


        // Test property getters!
        static void TestCardPropertyGetters()
        {
            Card c1 = new Card(1, 1);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Value. Expecting 1. " + c1.Value);
            Console.WriteLine("Suit. Expecting 1. " + c1.Suit);
            Console.WriteLine();
        }


        // Test property setters with validation and exception! (Needed to google how to test for exceptions, sorry! >.<")
        static void TestCardPropertySetters()
        {
            Card c1 = new Card(1, 1);

            Console.WriteLine("Testing valid setters");

            c1.Value = 2;
            c1.Suit = 2;

            Console.WriteLine("Expecting 2 of Diamonds. " + c1.ToString());
            Console.WriteLine();

            Console.WriteLine("Testing invalid setters");

            try
            {
                c1.Value = 20;
                Console.WriteLine("ERROR: Exception was not thrown for invalid Value.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Caught expected exception: " + ex.Message);
            }

            try
            {
                c1.Suit = 10;
                Console.WriteLine("ERROR: Exception was not thrown for invalid Suit.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Caught expected exception: " + ex.Message);
            }

            Console.WriteLine();
        }


        // Test matching methods!
        static void TestCardMatchingMethods()
        {
            Card c1 = new Card(1, 1);
            Card c2 = new Card(1, 2);
            Card c3 = new Card(2, 1);
            Card c4 = new Card(2, 2);

            Console.WriteLine("Testing matching methods");

            Console.WriteLine("Expecting true. " + c1.HasMatchingValue(c2));
            Console.WriteLine("Expecting false. " + c1.HasMatchingValue(c3));

            Console.WriteLine("Expecting true. " + c1.HasMatchingSuit(c3));
            Console.WriteLine("Expecting false. " + c1.HasMatchingSuit(c2));

            Console.WriteLine("Expecting false. " + c1.HasMatchingValue(c4));
            Console.WriteLine("Expecting false. " + c1.HasMatchingSuit(c4));

            Console.WriteLine();
        }


        // Test color methods!
        static void TestCardColorMethods()
        {
            Card c1 = new Card(1, 1); // Clubs
            Card c2 = new Card(1, 2); // Diamonds
            Card c3 = new Card(2, 3); // Hearts
            Card c4 = new Card(2, 4); // Spades

            Console.WriteLine("Testing color methods");

            Console.WriteLine("Expecting false. " + c1.IsRed());
            Console.WriteLine("Expecting true. " + c1.IsBlack());

            Console.WriteLine("Expecting true. " + c2.IsRed());
            Console.WriteLine("Expecting false. " + c2.IsBlack());

            Console.WriteLine("Expecting true. " + c3.IsRed());
            Console.WriteLine("Expecting false. " + c3.IsBlack());

            Console.WriteLine("Expecting false. " + c4.IsRed());
            Console.WriteLine("Expecting true. " + c4.IsBlack());

            Console.WriteLine();
        }


        // Test value methods!
        static void TestCardValueMethods()
        {
            Card c1 = new Card(1, 1);
            Card c2 = new Card(11, 1);
            Card c3 = new Card(12, 1);
            Card c4 = new Card(13, 1);

            Console.WriteLine("Testing value methods");

            Console.WriteLine("Expecting true. " + c1.IsAce());
            Console.WriteLine("Expecting false. " + c1.IsFaceCard());

            Console.WriteLine("Expecting false. " + c2.IsAce());
            Console.WriteLine("Expecting true. " + c2.IsFaceCard());

            Console.WriteLine("Expecting false. " + c3.IsAce());
            Console.WriteLine("Expecting true. " + c3.IsFaceCard());

            Console.WriteLine("Expecting false. " + c4.IsAce());
            Console.WriteLine("Expecting true. " + c4.IsFaceCard());

            Console.WriteLine();
        }
    }
}