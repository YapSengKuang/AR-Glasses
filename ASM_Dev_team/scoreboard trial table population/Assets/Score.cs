using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class NewBehaviourScript : MonoBehaviour
{
    public string name;
    public float score;

    public Score(string name, float score)
    {
        this.name = name;
        this.score = score;
    }
}
