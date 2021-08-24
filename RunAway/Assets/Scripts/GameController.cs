using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public GameObject youWinText;
    public int score;
    public Text scoreText;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (score == 50) PlayerWin();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score :" + score;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true); gameOver = true;
    }

    public void PlayerWin()
    {
        youWinText.SetActive(true); gameOver = true;
    }
}
