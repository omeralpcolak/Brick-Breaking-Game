using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int sumBrickNumber;
    public Sprite[] brickSprite;
    private int maxCollisionNumber;
    private int collisionNumber;
    private Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        maxCollisionNumber = brickSprite.Length+ 1;
        sumBrickNumber++;
        scoreScript = GameObject.FindObjectOfType<Score>().GetComponent<Score>();
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
                scoreScript.sumScore();
                sumBrickNumber--;
                Debug.Log(sumBrickNumber);

                if (sumBrickNumber <= 0)
                {
                    GameObject.FindObjectOfType<GameControl>().NextScene();
                }

                Destroy(gameObject);
            } else
            {
                GetComponent<SpriteRenderer>().sprite = brickSprite[collisionNumber - 1];
            }
        }
    }

}
