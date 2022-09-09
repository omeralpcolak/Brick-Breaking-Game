using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool oyunBasladi = false;
    private GameObject pedal;
    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {   
        if (!oyunBasladi)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0))
        {   
            oyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }
}
