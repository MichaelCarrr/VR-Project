using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject GreenCube; 
    public GameObject RedCube; 

    float t = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime; 
        if (t <= 0)
        { 
            t = Random.Range(0.5f, 2.0f); 

            var pos = new Vector3(Random.Range(-2,3), 1, 20); 
            var which = Random.Range(0,2); 
            if(which == 0) 
            { 
                Instantiate(GreenCube, pos, Quaternion.identity);
            } else { 
                Instantiate(RedCube, pos, Quaternion.identity);
            }
        }
    }
}
