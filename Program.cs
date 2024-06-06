
 Console.WriteLine("Hello, Isaac!");

 string myFirstFriend = "    maria     ";
 myFirstFriend=myFirstFriend.Trim();
 string mySecondFriend = "    peter   ";
string friends = $"My two friends are {myFirstFriend.Trim()} and {mySecondFriend.Trim()}";
 Console.WriteLine(friends);
 friends=friends.Replace("peter","John");
 Console.WriteLine(friends);

 Console.WriteLine(friends);
 Console.WriteLine(friends.Contains("peter"));
 Console.WriteLine(friends.StartsWith("My "));



 int a=4;
 int b=3;
 int c=5;
 if(a+b+c>10 && (a==c)){
     Console.WriteLine("a+b+c is greater than 10");

 }else{
     Console.WriteLine("This is wrong");
 };

 if(a+b+c>10 || (a==c)){
     Console.WriteLine("a+b+c is greater than 10");

 }else{
     Console.WriteLine("This is wrong");
 };

 int counter=0;

 while(counter<5)
 {
     counter++;
     Console.WriteLine(counter);
 }


do{
    counter++;
    Console.WriteLine(counter);
}
while(counter<5);



//   for loop
 for(
     int i=0;  //setup/initialization
     i<5;   //conditional
     i++){   //iteration (increment)
 Console.WriteLine(i);
 }

 for (int row=1; row < 11; row++ ){
     for(char column= 'a' ; column < 'c'; column++){
         Console.WriteLine($"The cell is ({row},{column})");
     }
 }
//  Collections
 var names = new List<string> { "Scott", "Ana","david", "Felipe" };
 names.Sort();
  names=[..names, "david"];
 foreach (var name in names)
 {
     Console.WriteLine($"{name.ToUpper()!}");
 }

var numbers = new List<int> { 45,87,99,45,68,97 ,106};
Console.WriteLine($"This numbers are sorted {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"This numbers are sorted {numbers.IndexOf(99)}");

 foreach (var number in numbers)
 {
     Console.WriteLine($"{number}");
 }

//  Languange integrated Query(LINQ)

 List<int> scores = [97, 45, 94, 86, 100, 92, 81, 60];

 for(int i=0; i< scores.Count; i++){
     if(scores[i] > 80){
         Console.WriteLine($"Found a score over 80 {scores[i]}");
     }
 }


// Define the query expression.
//  IEnumerable<int> scoreQuery =
//  from score in scores
//  where score > 80
//  orderby score descending
//  select score;
 var scoreQuery=scores.Where(s => s > 80).OrderByDescending(s => s);
 List<int> myScores=scoreQuery.ToList();

//  Execute the query.
 Console.WriteLine(scoreQuery.Count());
 foreach (var score in myScores)
 {
     Console.WriteLine(score);
 }


//  using System;

//  namespace myNamespace
//  {
//      public class myApp{
//          public static void Main()
//          {
//              Console.WriteLine("Hello");
//          }
//      }
//  }



// Console.WriteLine("Hello");
var p1= new Person("Scott","Hanselman",new DateOnly(1970,1,1)); 
  

    
var p2= new Person(  "David","Flower",new DateOnly(1970,1,1)
  ); 

  p1.Pets.Add(new Dog("Fred"));
  p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people=[p1,p2];

foreach (var person in people)
{
            Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"{pet}");
    }
}

// Console.WriteLine(people.Count);
class Person(string firstName, string lastName, DateOnly birthday)
{
    public string First { get;}=firstName;
    public string Last { get;}=lastName;
    public DateOnly Birthday { get;}= birthday;
    public List<Pet> Pets{get;}= new();

    public override string ToString()
    {
        return $"Human {First}{Last}";
    }
}

public abstract class Pet(string firstName)
{
    public string First { get;}=firstName;
    public abstract string makeNoise();

    public override string ToString()
    {
        return $" {First} and I am a {GetType().Name} and I {makeNoise()}";
    }
}

public class Cat(string firstName): Pet(firstName)
{
    public override string makeNoise()=>"meow";
}

public class Dog(string firstName): Pet(firstName)
{
    public override string makeNoise()=>"bark";
}