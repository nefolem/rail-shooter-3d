using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestuction : MonoBehaviour
{
    [SerializeField] float destroyTime;
    
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
