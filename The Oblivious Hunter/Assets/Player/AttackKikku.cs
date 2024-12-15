using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackkikku : MonoBehaviour
{


  //  Rigidbody rb;
    Transform tr;
    bool kikkuhit = false;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        //tr.rotation =new Quaternion(0.0f,0.0f,90.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ok");
        transform.position += new Vector3(1.0f,0.0f,0.0f) * Time.deltaTime;
    }
   void OnCollisionEnter(Collision collision)
    {
        kikkuhit = true;
        //DestroyObject(this);
    }
}
