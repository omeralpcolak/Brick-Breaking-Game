using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public UnityEngine.UI.Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Your Score: "+ GameObject.FindObjectOfType<Score>().GetComponent<Score>().returnScore(); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToTheAnaSahne ()
    {
        SceneManager.LoadScene(0);
    }
}
