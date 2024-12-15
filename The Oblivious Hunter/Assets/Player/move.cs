using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public int Hp = 10;
    public int TypeOfAttack = 5;
    Rigidbody rb;
    Transform tr;
    private Vector2 moveInput;

    //private Gamepad


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movex = new Vector3(Input.GetAxis("Horizontal"), 0);

        tr.position += movex * Time.deltaTime;


        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("buttonfggrb");

            rb.AddForce(0, 400, 0);

        }
        if (Input.GetKeyDown("joystick button 2"))
        {
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            //Debug.Log("buttonY");
            rb.AddForce(transform.forward.x, 5.0f, transform.forward.z);
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }
    }


    void Dead()
    {


    }
}