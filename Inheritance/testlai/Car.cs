namespace testlai
{
    
    public class Car
    {
        protected int age {get;set;}
        protected string name {get;set;}
        public Car(int age, string name){
           this.age=age;
           this.name=name;
        }
        public void Call(){
            Console.WriteLine($"Hey{name} and {age}");
            
        }
        

    }
    
}