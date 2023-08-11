using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blueball : MonoBehaviour
{
    public GameObject textbox1;
    public GameObject SphereRed;
    public GameObject resultText;

    private bool showdist = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        float dist = (transform.position.y - SphereRed.transform.position.y);

        if (SphereRed.GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0))
        {
            showdist = true;

            
        }
        else
        {

        }

        if (showdist)
        {
            textbox1.GetComponent<Text>().text = dist.ToString();
        }
        else
        {
            textbox1.GetComponent<Text>().text = transform.position.ToString();
        }

        // Calculate the difference between the z-coordinates of the two game objects
        float zDiff = SphereRed.transform.position.z - transform.position.z;

        // Set the text of the resultText component to the calculated difference
        resultText.GetComponent<Text>().text = "Z1 - Z2 = " + zDiff.ToString();
    }
}
