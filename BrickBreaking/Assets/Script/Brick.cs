using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] brickSprite;
    private int maxCollisionNumber;
    private int collisionNumber;
    // Start is called before the first frame update
    void Start()
    {
        maxCollisionNumber = brickSprite.Length+ 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("ball"))
        {
            collisionNumber++;
            
            if (collisionNumber >= maxCollisionNumber)
            {
                Destroy(gameObject);
            } else
            {
                GetComponent<SpriteRenderer>().sprite = brickSprite[collisionNumber - 1];
            }
        }
    }

}
