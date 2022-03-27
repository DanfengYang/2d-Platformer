using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    float lifeTime = 2;
    void Awake()
    {
        //Destroy(gameObject, lifeTime);
        StartCoroutine(DestroyTimer());
    }


    private IEnumerator DestroyTimer()
    {

        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            lifeTime--;
            Debug.Log(lifeTime);


            if (lifeTime <= 0)

            {
                Destroy(gameObject);

            }
        }

    }
}
