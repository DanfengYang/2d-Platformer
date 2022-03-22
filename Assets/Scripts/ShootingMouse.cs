using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// show how to aim a turret and fire hitscan weapon based on mouse aiming

// place this on player


public class ShootingMouse : MonoBehaviour
{
    //bool active;

    public GameObject explodePrefab;
    //assign this in inspector
    bool enteredTrigger = false;

    public AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        //mouse aiming: always face towards the mouse cursor position
        if (enteredTrigger == true)
        {
            Vector3 mouseCursorPositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // transforming mouse position to a game space position

            Vector2 fromPlayerToMouseCursor = mouseCursorPositionInWorld - transform.position;
            float playerDistance = Vector2.SqrMagnitude(fromPlayerToMouseCursor);
            // the distance  = mouse position - player posiion

            transform.right = fromPlayerToMouseCursor;
            Debug.DrawRay(transform.position, fromPlayerToMouseCursor, Color.cyan);


            //fire a raycast from player to mouse 
            Ray2D myRay = new Ray2D(transform.position, transform.right);
            float myMaxRayDistance = 1000f;


            RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDistance,1<<0);


            // instantiate something at impact point, if we hit something

            if (myRayHit.collider != null && Input.GetMouseButtonDown(0))
                // click to instantiate
                //&& myRayHit.collider.tag != "Player"
                // && playerDistance<= 10f 
            {
                //instantiate something at impact point 
                Instantiate(explodePrefab, myRayHit.point, Quaternion.Euler(0, 0, 0));
                myAudioSource.Play();

                // now, delete/destroy the object the raycast hit


                if (myRayHit.collider.tag == "remover")
                {
                    //DestroyWithTag("remover");

                    Destroy(myRayHit.collider.gameObject);
                    
                }
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

            enteredTrigger = true;

    }

}
    //void DestroyWithTag(string destroyTag)
    //{
    //    GameObject[] destroyObject;
    //    destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
    //    foreach (GameObject oneObject in destroyObject)
    //        Destroy(oneObject);
    //}

