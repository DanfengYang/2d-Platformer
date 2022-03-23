using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealedSound : MonoBehaviour
{
    public AudioSource thisAudioSource;
    // Start is called before the first frame update

    bool hasPlayed = false;
    void Start()
    {
        thisAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        
            Debug.Log("entered");

        

            if (!hasPlayed)
            {
                thisAudioSource.Play();
                hasPlayed = true;
            }

        

    }

   
}
