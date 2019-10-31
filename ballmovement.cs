using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript1 : MonoBehaviour
{   
    public float speed=5f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {  

       float horz = Input.GetAxisRaw("Horizontal");
       float vert = Input.GetAxisRaw("Vertical");
       rb.AddForce(speed*new Vector3(horz,0f,vert));
}
}
