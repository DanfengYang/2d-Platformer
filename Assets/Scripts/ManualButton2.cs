using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManualButton2 : MonoBehaviour
{
    SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    void Update()
    {


    }

    GameObject GetTarget()
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.transform.position, target);
        if (hit)
        {
            return hit.collider.gameObject;
        }
        return null;
    }

    public void LoadLevel2()
    {


        SceneManager.LoadScene("level2");
    }


    private void OnMouseOver()
    //only works when in the zone
    {
        if (Input.GetMouseButtonDown(0)) //Left
        {
            GameObject hit = GetTarget();

            if (hit != null)
            {
                spriteRenderer.color = new Color(0.3f, 0.7f, 0.7f, 1.0f);

                LoadLevel2();
            }
        }
    }
}



