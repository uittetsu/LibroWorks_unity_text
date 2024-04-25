using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
