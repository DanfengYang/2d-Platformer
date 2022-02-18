using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class WinningTrigger: MonoBehaviour
{
    [SerializeField] private TMP_Text winningText;
    [SerializeField] private TMP_FontAsset font1;

    public float timeRemaining = 10;
    string youWonText = "You Won!!!";

    bool won = false;

    GameObject player;
    GainItem gainitem;


    void Start()
    {
        winningText.font = font1;
        player = GameObject.FindGameObjectWithTag("Player");
        gainitem = player.GetComponent<GainItem>();
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
            gainitem.itemNumber = 0;
        }

        if (timeRemaining <= 0)

        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

}
