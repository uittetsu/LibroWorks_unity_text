using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSceneController : MonoBehaviour
{
    public static int score = 0;
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameScoreText = GameObject.Find("ScoreText");
        scoreText = gameScoreText.GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFailed()
    {
        Invoke("OnLoadGameScene", 1.5f);
    }

    private void OnLoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = score.ToString();
    }

    public void OnGoal()
    {
        GameObject bear = GameObject.Find("Bear@Walking");
        BearController script = bear.GetComponent<BearController>();
        script.OnStop();
        Invoke("OnLoadResultScene", 1.5f);
    }

    private void OnLoadResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
