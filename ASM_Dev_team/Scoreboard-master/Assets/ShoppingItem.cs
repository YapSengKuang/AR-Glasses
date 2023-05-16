// The 'using' keyword imports the System namespace, which contains the Serializable attribute.
using System;

// This line defines a new public class called Score.
// The [Serializable] attribute indicates that instances of this class can be serialized and deserialized.
[Serializable]
public class ShoppingItem
{
    // These two public fields are used to store the name and score of a player's score.
    public string name;
    public string quantity;

    // This is the constructor for the Score class.
    // It takes in two parameters: a string for the player's name and a float for their score.
    public ShoppingItem(string name, string quantity)
    {
        // This line assigns the 'name' parameter to the 'name' field of the Score instance being constructed.
        this.name = name;

        // This line assigns the 'score' parameter to the 'score' field of the Score instance being constructed.
        this.quantity = quantity;
    }
}

