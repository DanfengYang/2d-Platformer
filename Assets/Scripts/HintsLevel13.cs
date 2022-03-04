using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintsLevel13 : MonoBehaviour
{

    string objective = "Try to escape from this place! ";
    string hint1 = "A oneway door that only opens when you revealed all 3 arts. You haven't seen all of them yet. ";
    string hint2 = "You have revealed all 3 arts! Hop right in! ";

    //bool checkedLadder = false;


    [SerializeField] private TMP_Text hintsText;
    [SerializeField] private TMP_FontAsset font1;

    GameObject player;
    //declare the player
    GainItem gainitem;
    //store GainItem into gainitem

    void Start()
    {
        //hintsText.text = objective;
        hintsText.font = font1;

        player = GameObject.FindGameObjectWithTag("Player");
        //get the player
        gainitem = player.GetComponent<GainItem>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (gainitem.itemNumber != 3)
            {
                hintsText.text = hint1;


            }
            else
            {

                hintsText.text = hint2;
            }
        }



    }

    private void OnTriggerExit2D(Collider2D collision) {

        if (collision.gameObject.tag == "Player")
        {

            hintsText.text = objective;
        }


    }



    void Update()
    {

        
    }
}
