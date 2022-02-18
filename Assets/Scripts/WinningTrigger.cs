using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class WinningTrigger: MonoBehaviour
{
    [SerializeField] private TMP_Text winningText;
    [SerializeField] private TMP_FontAsset font1;

    public float timeRemaining = 5;
    string youWonText = "You Won!!!";

    bool won = false;


    void Start()
    {
        winningText.font = font1;
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            won = true;
        }

    }

    void Update()
    {
        if (timeRemaining > 0 && won == true)

        {
            winningText.text = youWonText;
            timeRemaining -= Time.deltaTime;
        }

        if (timeRemaining <= 0)

        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}
