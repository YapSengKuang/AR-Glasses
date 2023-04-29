using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class ScoreUi : MonoBehaviour
{
    public TextAsset textAssetData;
    public ScoreManager scoreManager;   
    public RowUi rowUi;
    
 
    [System.Serializable]
    public class Country
    {
        public int rank;
        public string name;
        public int score;
    }
    [System.Serializable]
    public class CountryList
    {
        public Country[] country; 
    }

    public CountryList myCountryList = new CountryList();

    void Start()
    {
        textAssetData = Resources.Load<TextAsset>("data");

        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        int tablesize = data.Length / 3 - 1;
        myCountryList.country = new Country[tablesize];

        for (int i = 0; i < tablesize; i++)
        {
            myCountryList.country[i] = new Country();
            myCountryList.country[i].rank = int.Parse(data[3 * (i + 1)]);
            myCountryList.country[i].name = data[3 * (i + 1) + 1];
            myCountryList.country[i].score = int.Parse(data[3 * (i + 1) + 2]);
        }

        for (int i = 0; i < tablesize; i++)
        {
            scoreManager.AddScore(new Score(myCountryList.country[i].name, myCountryList.country[i].score));
        }
        
        
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}

