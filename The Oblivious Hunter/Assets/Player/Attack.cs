using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    public int TypeOfAttack = 5;
    Rigidbody rb;
    Transform tr;
    public GameObject panti;
    public GameObject kikku;
    public Transform attackPosition;

    //private Gamepad


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("joystick button 2"))
        {
            //Debug.Log("パンチ");
            Instantiate(panti, attackPosition.position+new Vector3(3.0f,0.0f,0.0f), attackPosition.rotation);
        }

        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("キック");
            Instantiate(kikku, attackPosition.position + new Vector3(3.0f, 0.0f, 0.0f), attackPosition.rotation);

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
}