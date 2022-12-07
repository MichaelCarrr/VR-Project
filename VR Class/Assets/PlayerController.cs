using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;


    public void Start() { 

        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() {
    #if UNITY_EDITOR
        var h = 0;
        var v = 0;

        int something = 3;
        if (Input.GetKey(KeyCode.W)) v = 1;
        if (Input.GetKey(KeyCode.S)) v = -1;

        if (Input.GetKey(KeyCode.A)) h = -1;
        if (Input.GetKey(KeyCode.D)) h = 1;
    #else
        // https://developer.oculus.com/documentation/unity/unity-ovrinput/
        var h = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        var v = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;

    #endif

        rb.AddForce(new Vector3(h, 0, v) * something);

    }
}
