using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideTOFTPScripts : MonoBehaviour
{

    
    public GameObject rightventricularhypertrophytouchpoint;
    public GameObject stenoticpulmonarytrunktouchpoint;
    public GameObject overarchingaortatouchpoint;
    public GameObject membranousseptumdefecttouchpoint;
    
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
           
            rightventricularhypertrophytouchpoint.SetActive(false);
            stenoticpulmonarytrunktouchpoint.SetActive(false);
            overarchingaortatouchpoint.SetActive(false);
            membranousseptumdefecttouchpoint.SetActive(false);
         

            btnpressed = true;
            btndisplay.text = "Show Touchpoints";
            Debug.Log("Touchpoints are hidden");

        }

        else if (btndisplay.text == "Show Touchpoints")
        {
            
            rightventricularhypertrophytouchpoint.SetActive(true);
            stenoticpulmonarytrunktouchpoint.SetActive(true);
            overarchingaortatouchpoint.SetActive(true);
            membranousseptumdefecttouchpoint.SetActive(true);
         
            btndisplay.text = "Hide Touchpoints";
            Debug.Log("Touchpoints are visible");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

