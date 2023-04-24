using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;
    // Start is called before the first frame update
    void Start()
    {
        sd = new ScoreData();
    }

    public IEnumerable<Score> GetHighScores() 
    {
        return sd.scores.OrderByDescending(x >= x.score);
    }

    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }
}
