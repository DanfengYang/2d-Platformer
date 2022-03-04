using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoseBlood : MonoBehaviour

{

    [SerializeField] private TMP_Text bloodText;
    [SerializeField] private TMP_Text losingText;
    [SerializeField] private TMP_FontAsset font1;


    
    public float timeRemaining = 2;
    public int bloodCount = 10;
   


    string currentBloodText = "Current blood:";
    string youLostText = "You Lost! Restarting...";
    string playingText = "   ";


    GameObject player;
    GainItem gainitem;
    


    void Start()
    {
        
        bloodText.font = font1;
        losingText.font = font1;

        player = GameObject.FindGameObjectWithTag("Player");
        gainitem = player.GetComponent<GainItem>();
    }



    private void OnTriggerEnter2D(Collider2D collision)


    {
        Debug.Log("hit ");
        if (collision.gameObject.tag == "spike" && bloodCount >0)
        {




            //Destroy(collision.gameObject);

            bloodCount --;
            Debug.Log("blood = " + bloodCount);
            bloodText.text = currentBloodText + bloodCount;


        }



        //Destroy(collision.gameObject);


    }






    void Update()
    {
        if (timeRemaining > 0 && bloodCount <= 0)

        {
            losingText.text = youLostText;
            timeRemaining -= Time.deltaTime;
            gainitem.itemNumber = 0;
        }

        if (timeRemaining <= 0)

        {
            
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                }
    }


}

