using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBallMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0)*5);

        if (Input.GetKey(KeyCode.S))
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0)*5);


        if (Input.GetKey(KeyCode.A))
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1)*5);

        if (Input.GetKey(KeyCode.D))
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1)*5);
    }
}
