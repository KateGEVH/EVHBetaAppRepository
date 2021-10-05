using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoTutorialOpenScript : MonoBehaviour
{
    
    
    public Button videotutorialbtn;
    public Button closebtn;
    public GameObject videotutorialpopup;

    //Start is called before the first frame update

    void Start()
    {
        videotutorialbtn.GetComponent<Button>();
        videotutorialbtn.onClick.AddListener(VideoTutorialOpen);
        closebtn.GetComponent<Button>();
        closebtn.onClick.AddListener(VideoTutorialClose);
    }

    public void VideoTutorialOpen()
    {

        videotutorialpopup.SetActive(true);
        Debug.Log("The video screen is up!");
    }

    public void VideoTutorialClose()
    {
        videotutorialpopup.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
