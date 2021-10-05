using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayPauseButtonsScript : MonoBehaviour
{
    public Button PlayVideoButton;
    public VideoPlayer video;
    void Start()
    {

        Button playbtn = PlayVideoButton.GetComponent<Button>();
        playbtn.onClick.AddListener(TaskOnClick);
        playbtn.onClick.AddListener(playfunction);

        video = GetComponent<VideoPlayer>();

    }

    void TaskOnClick()

    {


        Debug.Log("You have clicked button");
    }

    public void playfunction()
    {
        video.Play();
    }

    public void pausefunction()
    {
        video.Pause();
    }

}

