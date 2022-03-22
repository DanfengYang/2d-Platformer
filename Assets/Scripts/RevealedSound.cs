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


    void OnTriggerEnter2D(Collision2D collision)

    {
        Debug.Log("entered");

        if (collision.gameObject.tag == "reveal")
        {
            

            if (!hasPlayed)
            {
                thisAudioSource.Play();
                hasPlayed = true;
            }

        }

    }

   
}
