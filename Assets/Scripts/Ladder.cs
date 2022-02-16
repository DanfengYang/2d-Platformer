using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour

{
    SpriteRenderer spriteRenderer;
    PlatformEffector2D  platformEffector;

    bool activated = false;
    int colorR = 125;
    int colorG = 145;
    int colorB = 225;
    
    void Start()
    {
       
            spriteRenderer = GetComponent<SpriteRenderer>();
            platformEffector = gameObject.GetComponent <PlatformEffector2D> ();




    }

    
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Return))
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
