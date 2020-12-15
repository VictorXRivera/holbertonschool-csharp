using System;

public enum Rating
{
    Good,
    Great,
    Excellent,
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;

    public Rating rating;

    public Dog(string Dog_name, float Dog_age, string Dog_owner, Rating Dog_rating)
    {
        name = Dog_name;
        age = Dog_age;
        owner = Dog_owner;
        rating = Dog_rating;
    }

    public override string ToString()
    {
        return String.Format($"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}");
    }
}