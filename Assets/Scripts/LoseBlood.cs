using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoseBlood : MonoBehaviour

{

    [SerializeField] private TMP_Text artifactText;
    [SerializeField] private TMP_FontAsset font1;





   

    public int bloodCount = 10;
   


    string bloodText = "Current blood:";


    void Start()
    {
        //artifactText.text = numberText;
        artifactText.font = font1;
    }



    private void OnTriggerEnter2D(Collider2D collision)


    {
        Debug.Log("hit ");
        if (collision.gameObject.tag == "spike")
        {




            //Destroy(collision.gameObject);

            bloodCount --;
            Debug.Log("blood = " + bloodCount);
            artifactText.text = bloodText + bloodCount;


        }



        //Destroy(collision.gameObject);


    }






    void Update()
    {
                if (bloodCount <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                }
            }
        }

