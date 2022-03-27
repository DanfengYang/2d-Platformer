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

    [SerializeField] private TMP_Text endingText;

    public float timeLosing = 10;
    public int bloodCount = 10;
   


    string currentBloodText = "Current blood:";
    string youLostText = "You Lost. ";
    string restartingText = "Restarting this level... ";
    string playingText = "   ";




    GameObject player;
    GainItem gainitem;

    public AudioSource myAudioSource;

    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

        bloodText.font = font1;
        losingText.font = font1;

        player = GameObject.FindGameObjectWithTag("Player");
        gainitem = player.GetComponent<GainItem>();
    }



    private void OnTriggerEnter2D(Collider2D collision)


    {
        //Debug.Log("hit ");
        if (collision.gameObject.tag == "spike" && bloodCount >0)
        {




            //Destroy(collision.gameObject);
            myAudioSource.Play();
            bloodCount --;
            Debug.Log("blood = " + bloodCount);
            bloodText.text = currentBloodText + bloodCount;


        }



        //Destroy(collision.gameObject);


    }






    void Update()
    {
        if (timeLosing > 0 && bloodCount <= 0)

        {
            losingText.text = youLostText;
            endingText.text = restartingText;

            //timeRemaining -= Time.deltaTime;
            gainitem.itemNumber = 0;
            StartCoroutine(RunTimer());
        }

    }


    private IEnumerator RunTimer(){
        
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            timeLosing -=Time.deltaTime;
            

            if (timeLosing <= 0) {
               

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }

    }


    

}

