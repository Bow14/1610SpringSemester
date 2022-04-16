using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score;
    public bool isGameActive;

    public Button restartButton;

    private float spawnRate = 1.0f;
    public GameObject titleScreen;
    
    //public GameObject[] targets2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void StartGame(int difficutly)
    {
        isGameActive = true;
        score = 0;
        titleScreen.gameObject.SetActive(false);
        spawnRate /= difficutly;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

   

    IEnumerator SpawnTarget()
    {
        while (isGameActive) 
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    
    
}
