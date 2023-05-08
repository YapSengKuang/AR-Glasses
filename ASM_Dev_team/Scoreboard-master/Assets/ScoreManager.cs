// The 'using' keyword imports the System, System.Collections, System.Collections.Generic, System.Linq, and UnityEngine namespaces.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// This line defines a new public class called ScoreManager that inherits from MonoBehaviour.
public class ScoreManager : MonoBehaviour
{
    // This private field holds an instance of the ScoreData class.
    private ScoreData sd;

    // This method is called when the script instance is being loaded.
    // It retrieves the JSON string representation of the score data from PlayerPrefs and deserializes it into the sd field.
    void Awake()
    {
        var json = PlayerPrefs.GetString("scores", "{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
    }

    // This public method returns a list of Score objects sorted by score in descending order.
    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.score);
    }

    // This public method adds a Score object to the sd field's list of scores.
    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }

    // This method is called when the game object that this script is attached to is destroyed.
    // It calls the SaveScore method to save the score data to PlayerPrefs.
    private void OnDestroy()
    {
        SaveScore();
    }

    // This public method serializes the sd field into a JSON string and saves it to PlayerPrefs.
    public void SaveScore()
    {
        var json = JsonUtility.ToJson(sd);
        Debug.Log(json);
        PlayerPrefs.SetString("scores", json);
    }
}