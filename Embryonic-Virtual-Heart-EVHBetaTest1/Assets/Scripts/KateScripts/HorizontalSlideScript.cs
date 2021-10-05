using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HorizontalSlideScript : MonoBehaviour
{
    public Slider horizontalslider;
    //public int slidervalue;
    
    // Start is called before the first frame update
    void Start()
    {
        horizontalslider.GetComponent<Slider>();
        horizontalslider.onValueChanged.AddListener(rotatemodelx);
    }

    
    private float xpreviousslidervalue = 0;
  
    void rotatemodelx(float xslidervalue)
    {
        
       
            Debug.Log(xslidervalue);
        if (xslidervalue > xpreviousslidervalue)
        {
            transform.Rotate(new Vector3(0, -1, 0), 8);
            Debug.Log("Rotate to the right because slider value has increased");
            xpreviousslidervalue = xslidervalue;
            Debug.Log("previousslidervalue is now" + xpreviousslidervalue);
        }

        else if (xslidervalue < xpreviousslidervalue)
        {
            transform.Rotate(new Vector3(0, 1, 0), 8);
            Debug.Log("Rotate to the left because slider value has decreased");
            xpreviousslidervalue = xslidervalue;
            Debug.Log("previousslidervalue is now" + xpreviousslidervalue);
        }

        
        /*if (slidervalue <= 180 && slidervalue > 0)
        {
            transform.Rotate(new Vector3(0, -1, 0), 5);
            Debug.Log("Rotate to the right by one degree because slider value has increased");
        }
            

        else if(slidervalue >= -180 && slidervalue < 0)
        {
            transform.Rotate(new Vector3(0, 1, 0), 5);
            Debug.Log("Rotate to the left if slidervalue is between 0 and -180 degrees");
        }*/
    }

    
    
    
        
        void Update()
    {
        
    }
}
