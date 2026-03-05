namespace Assignment_03OOP
{
    #region Q01
    //a) A University has Departments.If the university is closed, the departments no longer exist.
    //--Composition

    //b) A Driver uses a Car.The driver does not own the car.
    //--Association

    //c) A Dog is an Animal.
    //
    //--Inheritance 

    //d) A Team has Players.If the team is deleted, the players still exist.
    //--Aggregation

    //e) A method receives a Logger as a parameter and calls it inside the method only.
    //--Dependency

    #endregion
    #region  Q02 
    //a) A parent class has a protected field.Can a child class in a different assembly access it?
    //--Yes
    //What about through an object instance from outside?
    //--No

    //b) What is the difference between protected internal and private protected?
    //--protected internal — Accessible anywhere in the same assembly (like internal) OR in derived classes in other assemblies (like protected)
    //--private protected — Accessible in the containing class OR derived classes in the same assembly only

    //c) What does the sealed keyword do when applied to a class?
    //-- Prevents inheritance
    //What about when applied to a method?
    //--Prevents further overriding


    //d) Can you create an object from a sealed class using new? Why or why not?
    //--Yes you can create an object from a sealed class using new.
    //Because sealed only prevents inheritance, not object creation.
    

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
