using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject textObject = GameObject.Find("ScoreText");
        TextMeshProUGUI scoreText = textObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = GameSceneController.score.ToString();
    }

    public void OnGameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
