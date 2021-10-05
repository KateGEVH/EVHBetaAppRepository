using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayButton : MonoBehaviour
{
    //bool isPlaying = false;
    public Text btndisplay;
    public Button vidplaybtn;
    public VideoPlayer vidtoplay;

    // Start is called before the first frame update
    void Start()
    {
        //vidplaybtn.GetComponent<Button>();
        
        vidplaybtn.onClick.AddListener(PlayPause);
        vidtoplay = GetComponent<VideoPlayer>();
        
    }

    void PlayPause()
    {
        if (vidtoplay.isPlaying)
        {
            Debug.Log("Pause Video");
            //isPlaying = false;
            //make pause
            vidtoplay.Pause();
            btndisplay.text = "Play";
            

        }

        else

        {
            Debug.Log("Play Video");
            //isPlaying = true;
            //make play
            vidtoplay.Play();
            btndisplay.text = "Pause";
        }
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
