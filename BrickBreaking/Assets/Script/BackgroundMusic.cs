using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    static bool MusicExist;
    // Start is called before the first frame update
    void Start()
    {   
        if (!MusicExist)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            MusicExist = true;
        } else
        {
            Destroy (gameObject);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
