using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public float score=0;
    public Text scoreText ;
    
    public static GameManager instance = null;
    private void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }
    public void AddScore()
    {
        score++;
        scoreText.text = "Score : " + score;
        if ( score >= 5)
            {
            Debug.Log("You win");
            scoreText.text = "You win";
        }
    }
    public void Lose()
    {
        Debug.Log("Lose");
        player.SetActive(false);
        scoreText.text = "You Lose";
    }
}
