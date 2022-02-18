using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintsText2 : MonoBehaviour
{
    string hint1 = "The sign says: Can't jump high enough? Maybe use a BOX...";
    string objective = "Try to escape from this place! ";

    [SerializeField] private TMP_Text hintsText;
    [SerializeField] private TMP_FontAsset font1;

    void Start()
    {
        hintsText.text = objective;
        hintsText.font = font1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hintsText.text = hint1;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hintsText.text = objective;
        }


    }


}
