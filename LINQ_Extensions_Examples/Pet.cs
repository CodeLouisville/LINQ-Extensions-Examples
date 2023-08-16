namespace LINQ_Extensions_Examples;

/// <summary>
/// Pet object that implements IEquatable.
/// Implements IEquatable so that we can custom decide which properties are used for an equalty comparasion
/// (otherwise it uses the reference of the object).
/// </summary>
internal class Pet : IEquatable<Pet>
{
    public string Name { get; }
    public int Age { get; }

    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool Equals(Pet? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Pet) obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }
}
