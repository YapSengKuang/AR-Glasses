// The 'using' keyword imports the System and System.Collections.Generic namespaces.
using System;
using System.Collections.Generic;

// This line defines a new public class called ScoreData.
// The [Serializable] attribute indicates that instances of this class can be serialized and deserialized.
public class ScoreData
{
    // This public field is a List of Score objects.
    public List<Score> scores;

    // This is the constructor for the ScoreData class.
    // It initializes the 'scores' field as a new empty List of Score objects.
    public ScoreData()
    {
        scores= new List<Score>();
    }
}

