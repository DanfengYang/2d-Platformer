using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ResetScene : MonoBehaviour
{

    bool gameOver = false;
    bool gameWin = false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
            {
                Debug.Log("pressed esc");
                SceneManager.LoadScene("openingScene");

            }
        }
    }
}
