using System;

public class Person : Entity {

  public Person (string name, int age) {
    Name = name;
    Age = age;
  }

  public string Name { get; private set; }
  public int Age { get; private set; }

  // Checks if the current object is equal to the specified object
  // returns boolean
  public override bool Equals (object obj) {

    if (obj == null || !GetType ().Equals (obj.GetType ()))
      return false;

    var person = (Person) obj;
    return Name.Equals (person.Name) && Age.Equals (person.Age);
  }
}

class SampleClass {

  public SampleClass () {
    var person = new Person ("Vincent", 1);
    Console.WriteLine ($"Vincent Id: {person.Id}");

    var person2 = new Person ("Vench", 1);
    Console.WriteLine ($"Vench Id: {person2.Id}");

    Console.WriteLine ($"Is Equal to Current object? {person.Equals(person2)}");
    Console.WriteLine ($"Is Equal to Current object? {person.Equals(null)}");
  }

}