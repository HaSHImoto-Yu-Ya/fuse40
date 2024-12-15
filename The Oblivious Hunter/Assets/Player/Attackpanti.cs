using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackpanti : MonoBehaviour
{


  //  Rigidbody rb;
  //  Transform tr;
    bool pantihit = false;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ok");
        transform.position += new Vector3(1.0f,0.0f,0.0f) * Time.deltaTime;
    }
   void OnCollisionEnter(Collision collision)
    {
        pantihit = true;
        //DestroyObject(this);
    }
}
