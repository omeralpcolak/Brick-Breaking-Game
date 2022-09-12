using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    private Vector3 firstPos;
    // Start is called before the first frame update
    void Start()
    {
        firstPos = transform.position;
        transform.position = new Vector3 (firstPos.x, firstPos.y-10f, firstPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp (transform.position, firstPos, 2*Time.deltaTime);
    }
}
