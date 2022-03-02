using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    float lifeTime = 1.0f;
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    
}
