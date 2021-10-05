using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideMembTPScript : MonoBehaviour
{


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
        if (btndisplay.text == "Hide Touchpoint")
        {
           
          
            membranousseptumdefecttouchpoint.SetActive(false);
            

            btnpressed = true;
            btndisplay.text = "Show Touchpoint";
            Debug.Log("Touchpoints are hidden");

        }

        else if (btndisplay.text == "Show Touchpoint")
        {
          
            membranousseptumdefecttouchpoint.SetActive(true);
         
            btndisplay.text = "Hide Touchpoint";
            Debug.Log("Touchpoints are visible");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
