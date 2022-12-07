using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    { 
        if(other.tag == this.tag) 
        { 
            Destroy(other.gameObject); 
        }
    }
}
