using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotator : MonoBehaviour
{
    Transform T;
    public float speed =5f;
    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = speed * new Vector3(1, 1, 1) * Time.deltaTime;
        T.rotation *= Quaternion.Euler(rot);
    }
}
