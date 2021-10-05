using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideNormalTPScript : MonoBehaviour
{

    public GameObject leftventricletouchpoint;
    public GameObject rightventricletouchpoint;
    public GameObject antleftatriumtouchpoint;
    public GameObject postleftatriumtouchpoint;
    public GameObject antrightatriumtouchpoint;
    public GameObject postrightatriumtouchpoint;
    public GameObject leftAVcanaltouchpoint;
    public GameObject rightAVcanaltouchpoint;
    public GameObject pulmonarytrunktouchpoint;
    public GameObject aortatouchpoint;
    public GameObject aorta2touchpoint;
    public GameObject conotruncalseptumtouchpoint;
    public GameObject membranousseptumtouchpoint;
    public GameObject muscularseptumtouchpoint;
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
            leftventricletouchpoint.SetActive(false);
            rightventricletouchpoint.SetActive(false);
            antleftatriumtouchpoint.SetActive(false);
            postleftatriumtouchpoint.SetActive(false);
            antrightatriumtouchpoint.SetActive(false);
            postrightatriumtouchpoint.SetActive(false);
            leftAVcanaltouchpoint.SetActive(false);
            rightAVcanaltouchpoint.SetActive(false);
            pulmonarytrunktouchpoint.SetActive(false);
            aortatouchpoint.SetActive(false);
            aorta2touchpoint.SetActive(false);
            conotruncalseptumtouchpoint.SetActive(false);
            membranousseptumtouchpoint.SetActive(false);
            muscularseptumtouchpoint.SetActive(false);

            btnpressed = true;
            btndisplay.text = "Show Touchpoints";
            Debug.Log("Touchpoints are hidden");

        }

        else if (btndisplay.text == "Show Touchpoints")
        {
            leftventricletouchpoint.SetActive(true);
            rightventricletouchpoint.SetActive(true);
            antleftatriumtouchpoint.SetActive(true);
            postleftatriumtouchpoint.SetActive(true);
            antrightatriumtouchpoint.SetActive(true);
            postrightatriumtouchpoint.SetActive(true);
            leftAVcanaltouchpoint.SetActive(true);
            rightAVcanaltouchpoint.SetActive(true);
            pulmonarytrunktouchpoint.SetActive(true);
            aortatouchpoint.SetActive(true);
            aorta2touchpoint.SetActive(true);
            conotruncalseptumtouchpoint.SetActive(true);
            membranousseptumtouchpoint.SetActive(true);
            muscularseptumtouchpoint.SetActive(true);
            btndisplay.text = "Hide Touchpoints";
            Debug.Log("Touchpoints are visible");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
