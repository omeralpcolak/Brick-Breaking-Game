using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp (farePos.x,-1.75f,1.75f), transform.position.y, transform.position.z);
        //transform.position = new Vector3 (ball.transform.position.x,transform.position.y,transform.position.z); 
    }
}
