using System.Diagnostics; // import stopwatch class
using LINQ_Extensions_Examples;

// seed pets
List<Pet> pets = new()
{
    new Pet("Fido", 3),
    new Pet("Rex", 5),
    new Pet("Rex", 11),
    new Pet("Mittens", 1),
    new Pet("Mittens", 1),
};

List<Pet> noPets = new();

// LINQ ForEach (iterate over every item in a collection)
Console.WriteLine("\nForEach");
pets.ForEach(pet => pet.Print());

// LINQ Where (filter an IEnumerable given a condition)
Console.WriteLine("\nWhere pet name starts with R");
var olderPets = pets.Where(pet => pet.Name.StartsWith('R'));
olderPets.Print();

// LINQ Distinct (get distinct values in an IEnumerable, returns an IEnumerable)
Console.WriteLine("\nDistinct pets");
var distinctPets = pets.Distinct();
distinctPets.Print();

// LINQ ToHashSet (get a HashSet (distinct values) from an IEnumerable)
Console.WriteLine("\nPets as HashSet");
var petSet = pets.ToHashSet();
petSet.Print();

// LINQ First (get the first item of an IEnumerable, throws an exception if no elements)
Console.WriteLine("\nFirst pet");
var firstPet = pets.First();
firstPet.Print();

// LINQ FirstOrDefault (get the first item of an IEnumerable, returns default (often null) value of an object if no elements)
Console.WriteLine("\nFirst pet or default");
var firstOrDefaultPet = noPets.FirstOrDefault();
firstOrDefaultPet.Print();

// LINQ Last (get the last item of an IEnumerable, throws an exception if no elements)
Console.WriteLine("\nLast pet");
var lastPet = pets.Last();
lastPet.Print();

// try/catch/finally + LINQ Single (get only element of an IEnumerable that satisfies condition, throws an exception if one item isn't returned)
Console.WriteLine("\nSingle pet");
var stopwatch = Stopwatch.StartNew();
try
{
    var singlePet = pets.Single(pet => pet.Name == "Rex");
    singlePet.Print();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine(stopwatch.ElapsedMilliseconds);
}

// LINQ OrderBy (sorts IEnumerable in ascending order)
Console.WriteLine("\nOrdered pets");
var orderedPets = pets.OrderBy(pet => pet.Name);
orderedPets.Print();

// example of method chaining
Console.WriteLine("\nMethod chaining");
pets.OrderBy(pet => pet.Name).First().Print();

// example of an extension method we wrote that sums ages of pets
Console.WriteLine("\nSum ages");
var sumAges = pets.SumAges();
// uses a ternary operator to prints out ages or a message (if null result)
Console.WriteLine(sumAges is null ? "No pets to sum" : sumAges);
