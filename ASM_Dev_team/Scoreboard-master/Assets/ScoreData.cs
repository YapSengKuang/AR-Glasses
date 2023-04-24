using System;
using System.Collections.Generic;

[Serializable]
public class ScoreData
{
    public List<Score> scores;

    public ScoreData()
    {
        scores= new List<Score>();
    }
}
