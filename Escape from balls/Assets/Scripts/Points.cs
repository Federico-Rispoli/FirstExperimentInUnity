using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime;

public class Points : MonoBehaviour
{
    public Text punteggio;
    public static float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            timer = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game") {
            timer += Time.deltaTime;
            punteggio.text = "Time: " + timer;
        }
        else if (SceneManager.GetActiveScene().name == "Death")
        {
            punteggio.text = "Time: " + Mathf.Round(timer * 1000.0f) * 0.001f;
        }
    }
}
