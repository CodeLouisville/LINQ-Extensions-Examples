namespace LINQ_Extensions_Examples;

internal static class PetExtensions
{
    /// <summary>
    /// Writes to console a Pet
    /// </summary>
    /// <param name="pet">pet to print out</param>
    public static void Print(this Pet? pet)
    {
        Console.WriteLine(
            pet is null
                ? "Pet is null"
                : $"Name: {pet.Name}, Age: {pet.Age}");
    }

    /// <summary>
    /// Writes to console a collection of Pets
    /// </summary>
    /// <param name="pets">pets to prints out</param>
    public static void Print(this IEnumerable<Pet> pets)
    {
        foreach (var pet in pets)
        {
            pet.Print();
        }
    }

    /// <summary>
    /// Sums ages of input pets
    /// </summary>
    /// <param name="pets">pets to sum</param>
    /// <returns>summed age or null if no pets</returns>
    public static int? SumAges(this IEnumerable<Pet> pets)
    {
        if (!pets.Any())
        {
            return null;
        }

        return pets.Sum(pet => pet.Age);
    }
}
