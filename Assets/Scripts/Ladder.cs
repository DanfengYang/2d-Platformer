using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour

{
    SpriteRenderer spriteRenderer;
    PlatformEffector2D  platformEffector;

    bool activated = false;
    int colorR = 0;
    int colorG = 0;
    int colorB = 0;

    GameObject player;
    //declare the player
    GainItem gainitem;
    //store GainItem into gainitem

    void Start()
    {
        


        spriteRenderer = GetComponent<SpriteRenderer>();
        platformEffector = gameObject.GetComponent<PlatformEffector2D>();

        player = GameObject.FindGameObjectWithTag("Player");
        //get the player
        gainitem = player.GetComponent<GainItem>();
    }

    
    void Update()
    {

        if(gainitem.itemNumber == 3)
        {


            if (!activated)
            {
                activated = true;
                //float alphaColor = Random.Range(0f, 1f);
                spriteRenderer.color = new Color(colorR,colorG,colorB,0.5f);

                //platformEffector.useOneWay.!enabled= ;
                //enable use one way
                platformEffector.useOneWay = true;


            }
        }


    }
}
