// The 'using' keyword imports the System.Collections, System.Collections.Generic, System.Linq, UnityEngine, and System namespaces.
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

// This line defines a new public class called ScoreUi that inherits from MonoBehaviour.
public class ScoreUi : MonoBehaviour
{
    // These public fields are used to reference a TextAsset object that contains the score data, a ScoreManager object, and a RowUi object.
    public TextAsset textAssetData;
    public ScoreManager scoreManager;   
    public RowUi rowUi;
    
    // These [Serializable] classes are used to deserialize the score data from the TextAsset object.
    [System.Serializable]
    public class Country
    {
        public int rank;
        public string name;
        public string score;
    }
    [System.Serializable]
    public class CountryList
    {
        public Country[] country; 
    }

    // This public field holds an instance of the CountryList class, which is used to store the score data.
    public CountryList myCountryList = new CountryList();

    // This method is called when the script instance is being loaded.
    void Start()
    {
        // Load the score data from the TextAsset object.
        textAssetData = Resources.Load<TextAsset>("MyShoppingLIst");

        // Split the score data into an array of strings using ',' and '\n' as delimiters.
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);

        // Calculate the size of the score data table.
        int tablesize = data.Length / 3 - 1;

        // Initialize the Country array in the CountryList with the calculated table size.
        myCountryList.country = new Country[tablesize];

        // Populate the Country array in the CountryList with the score data.
        for (int i = 0; i < tablesize; i++)
        {
            int arrayIndex = 3 * (i + 1);
            myCountryList.country[i] = new Country();
            myCountryList.country[i].rank = int.Parse(data[arrayIndex]);
            myCountryList.country[i].name = data[arrayIndex + 1];
            myCountryList.country[i].score = data[arrayIndex + 2];
        }

        // Add the score data to the ScoreManager.
        for (int i = 0; i < tablesize; i++)
        {
            scoreManager.AddScore(new Score(myCountryList.country[i].name, myCountryList.country[i].score));
            Debug.Log("Hello");
        }
        
        // Retrieve the high scores from the ScoreManager and display them in the UI.
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score;
        }
    }
}


