using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class WinningTrigger: MonoBehaviour
{
    [SerializeField] private TMP_Text winningText;
    [SerializeField] private TMP_FontAsset font1;

    [SerializeField] private TMP_Text endingText;

    public int timeWinning = 10;
    string youWonText = "Congradulations! You won this level. ";
    string goOnText = "Proceeding...";

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
        if (timeWinning > 0 && won == true)

        {
            winningText.text = youWonText;
            endingText.text = youWonText;
            //timeRemaining -= Time.deltaTime;
            gainitem.itemNumber = 0;
            StartCoroutine(RunTimer());
        }

        
    }

    private IEnumerator RunTimer()
    {

        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            timeWinning--;



            if (timeWinning <= 0)

            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);

            }
        }

    }

}
