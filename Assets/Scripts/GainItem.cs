using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GainItem : MonoBehaviour
{

    [SerializeField] private TMP_Text artifactText;
    [SerializeField] private TMP_FontAsset font1;


    //public bool checkedDoor = false;

    
    
   
    public int itemNumber = 0;
    

    string numberText = "Revealed arts:";



    
        
        void Start()
    {
        //artifactText.text = numberText;
        artifactText.font = font1;

      
    }



    private void OnTriggerEnter2D(Collider2D collision)


    {
        //Debug.Log("hit ");
        if (collision.gameObject.tag == "artifact") {


            print(collision.gameObject.name);

            Destroy(collision.gameObject);

            itemNumber++;
            Debug.Log("item number = " + itemNumber);
            artifactText.text = numberText + itemNumber;
           


        }



        //Destroy(collision.gameObject);
        

    }





    
    void Update()
    {
        
    }
}
