using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

public Rigidbody myrigidbody;


    void Start()
    {

myrigidbody.AddForce(0,500,0);


    }


    // Update is called once per frame
    void Update()
    {

    }
}
