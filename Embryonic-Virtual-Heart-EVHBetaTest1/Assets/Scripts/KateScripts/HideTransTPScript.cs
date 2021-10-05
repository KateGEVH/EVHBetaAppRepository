using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideTransTPScript : MonoBehaviour
{

    public GameObject leftpulmonarytrunktouchpoint;
    public GameObject rightaortatouchpoint;
    public Button hidetouchpointsbtn;
    public Text btndisplay;
    public bool btnpressed;


    //Start is called before the first frame update

    void Start()
    {
        hidetouchpointsbtn.GetComponent<Button>();
        hidetouchpointsbtn.onClick.AddListener(TouchPointControl);
    }


    public void TouchPointControl()
    {
        if (btndisplay.text == "Hide Touchpoints")
        {
          
            leftpulmonarytrunktouchpoint.SetActive(false);
            rightaortatouchpoint.SetActive(false);
            btnpressed = true;
            btndisplay.text = "Show Touchpoints";
            Debug.Log("Touchpoints are hidden");

        }

        else if (btndisplay.text == "Show Touchpoints")
        {
         
            leftpulmonarytrunktouchpoint.SetActive(true);
            rightaortatouchpoint.SetActive(true);
            btndisplay.text = "Hide Touchpoints";
            Debug.Log("Touchpoints are visible");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

