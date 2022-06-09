using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        scoreText.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp(int i)
    {
        score = score + i;
        scoreText.text = score.ToString();
    }
}
