namespace ObjectsAndClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat  
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Color { set; get; }
        public bool IsAsleep { set; get; }
        
        List<Cat> AllBLackAwakeCats = new List<Cat>(); 
        
        public string SayHello() {

            if (IsAsleep) { 

                return "The cat is sleeping !";
            }

            return $"Hello My name is {Name} and I am {Age} years old.";
        }

        public void GoesToSleep() {
            IsAsleep = true;  
        }

        public void Awake() {
            IsAsleep = false;
        }
    }
}
