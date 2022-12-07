using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{

    public float speed = -3; 

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
