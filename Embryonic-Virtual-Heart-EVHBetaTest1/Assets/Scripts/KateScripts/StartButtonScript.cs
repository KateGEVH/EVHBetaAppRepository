using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
   
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}


/* public Button StartButton; This is just here to get the button directly with the script, but I don't think that is necessary
    
    // Start is called before the first frame update
    void Start()
    {

        Button startbtn = StartButton.GetComponent<Button>();
        startbtn.onClick.AddListener(TaskOnClick);
        startbtn.onClick.AddListener(LoadScene);

       
    }

    void TaskOnClick()

    {
        Debug.Log("You have clicked button");
    }
   */