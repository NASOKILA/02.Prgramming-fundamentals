namespace ObjectsAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class ObjectsAndClasses
    {
        static void Main(string[] args)
        {

            var CatFirts = new Cat();
            CatFirts.Name = "Sisa";
            CatFirts.Age = 5;
            CatFirts.Color = "black";
            CatFirts.IsAsleep = false;

            var CatSecond = new Cat();
            CatSecond.Name = "Mika";
            CatSecond.Age = 7;
            CatSecond.Color = "White";
            CatSecond.IsAsleep = true;

            var CatThird = new Cat();
            CatSecond.Name = "Nino";
            CatSecond.Age = 1;
            CatSecond.Color = "Grey";
            CatSecond.IsAsleep = true;

            Console.WriteLine(CatFirts.Name);
            Console.WriteLine(CatSecond.Name);
            Console.WriteLine(CatThird.Name);

            Console.WriteLine(); Console.WriteLine();

            List<Cat> AllBLackAndAwakeCats = new List<Cat>();
            for (int i = 0; i < 100; i++)
            {
                var currentCat = new Cat();
                currentCat.Name = "Cat" + i.ToString();
                currentCat.Age = i % 10;
                currentCat.Color = "Black";
                currentCat.IsAsleep = false;

                AllBLackAndAwakeCats.Add(currentCat);
            }

            Console.WriteLine(AllBLackAndAwakeCats[15].Name);

            Console.WriteLine(); Console.WriteLine();

            var CatFour = new Cat
            {
                Name = "Martaka",
                Age = 6,
                Color = "Yelow",
                IsAsleep = false
            };

            CatFour.Name = "Tapaka";

            Console.WriteLine(CatFour.Name);

            Console.WriteLine(); Console.WriteLine();

            var CatFirstIntro = CatFirts.SayHello();
            Console.WriteLine(CatFirstIntro);

            Console.WriteLine(CatSecond.SayHello());

            Console.WriteLine(); Console.WriteLine();

            CatThird.GoesToSleep();
            Console.WriteLine(CatThird.IsAsleep);
            Console.WriteLine(CatThird.SayHello());

            CatThird.Awake();
            Console.WriteLine(CatThird.IsAsleep);
            Console.WriteLine(CatThird.SayHello());

            var firstDate = new DateTime(2017, 05, 02);
            var secondDate = new DateTime(2015, 02, 01);

            Console.WriteLine(); Console.WriteLine();

            Random rand = new Random();

            var randNum = rand.Next(1, 10);

            Console.WriteLine(randNum);

            Console.WriteLine(); Console.WriteLine();

            var instance = new ObjectsAndClasses();
            instance.UnstatcMethod();
        }

        public void UnstatcMethod()
        {
            Console.WriteLine("Static method!");
        }

    }
}
