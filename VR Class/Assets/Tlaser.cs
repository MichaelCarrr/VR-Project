using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tlaser : MonoBehaviour
{
    GameObject player; 
    LineRenderer lr; 
    float range = 50; 

    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player"); 
        lr = GetComponent<LineRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        var endPos = transform.TransformPoint(0, 0, range); 

        RaycastHit hit; 

        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        { 
            endPos = hit.point; 
        }

        lr.SetPosition(0, transform.position); 
        lr.SetPosition(1, endPos);
    }
}
