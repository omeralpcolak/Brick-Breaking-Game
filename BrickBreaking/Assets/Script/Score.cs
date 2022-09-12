using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    public void sumScore()
    {
        score++;
    }

    public int returnScore()
    {
        return score;
    }

    public void ResetScore ()
    {
        score = 0;
    }

}
