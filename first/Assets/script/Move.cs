using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public GameObject textbox;
    public Vector3 startingvelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = startingvelocity;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  Vector3 pos = transform.position;
        // pos.x += 0.1f;
        //transform.position = pos;
        textbox.GetComponent<Text>().text = transform.position.y.ToString();
        textbox.transform.position = transform.position;
        // Vector3 posy = transform.position;
        //pos.y += 0.1f;
        //transform.position = pos;
        // Vector3 posz = transform.position;
        // pos.y += 0.1f;
        // transform.position = pos;
    }
}

