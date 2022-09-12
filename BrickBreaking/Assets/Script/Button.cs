using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public void DigerSahne()
    {   
        Brick.sumBrickNumber = 0;
        GameObject.FindObjectOfType<Score>().GetComponent<Score>().ResetScore();
        SceneManager.LoadScene("Level1");
        
    }
}
