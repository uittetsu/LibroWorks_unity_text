using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject gameSceneController = GameObject.Find("GameSceneController");
        GameSceneController script = gameSceneController.GetComponent<GameSceneController>();
        script.AddScore(100);

        Destroy(gameObject);
    }
}
