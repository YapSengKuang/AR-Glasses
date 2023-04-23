using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreU : MonoBehaviour
{
    public RowUI rowUi;
    public ScoreManager scoreManager; 

    void Start()
    {
        scoreManager.AddScore(new Score("eran", 6));    
        scoreManager.AddScore(new Score("elongated", 66));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++) 
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUI();
            row.rank.text = (i+1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}
