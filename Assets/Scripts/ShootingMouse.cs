using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// show how to aim a turret and fire hitscan weapon based on mouse aiming

// place this on player


public class ShootingMouse : MonoBehaviour
{


    public GameObject explodePrefab;
    //assign this in inspector


    void Update()
    {


        //mouse aiming: always face towards the mouse cursor position

        Vector3 mouseCursorPositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transforming mouse position to a game space position

        Vector2 fromPlayerToMouseCursor = mouseCursorPositionInWorld - transform.position;
        // the distance  = mouse position - player posiion

        transform.right = fromPlayerToMouseCursor;
        Debug.DrawRay(transform.position, fromPlayerToMouseCursor, Color.cyan);


        //fire a raycast from player to mouse 
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myMaxRayDistance = 10f;


        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDistance);




        // instantiate something at impact point, if we hit something

        if (myRayHit.collider != null && Input.GetMouseButtonDown(0))  // click to instantiate
        {
            //instantiate something at impact point 
            Instantiate(explodePrefab, myRayHit.point, Quaternion.Euler(0, 0, 0));

            // now, delete/destroy the object the raycast hit


            if (myRayHit.collider.tag == "remover")
            {
                //DestroyWithTag("remover");

                Destroy(myRayHit.collider.gameObject);
            }
        }

        }

    //void DestroyWithTag(string destroyTag)
    //{
    //    GameObject[] destroyObject;
    //    destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
    //    foreach (GameObject oneObject in destroyObject)
    //        Destroy(oneObject);
    //}
}
