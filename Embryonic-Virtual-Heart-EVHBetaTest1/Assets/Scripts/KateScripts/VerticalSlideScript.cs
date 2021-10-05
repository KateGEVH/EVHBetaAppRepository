using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VerticalSlideScript : MonoBehaviour
{
    public Slider verticalslider;
    private float ypreviousslidervalue = 0;

    // Start is called before the first frame update
    void Start()
    {
        verticalslider.GetComponent<Slider>();
        verticalslider.onValueChanged.AddListener(rotatemodely);
    }
    void rotatemodely(float yslidervalue)
    {


        Debug.Log(yslidervalue);
        if (yslidervalue > ypreviousslidervalue)
        {
            transform.Rotate(new Vector3(-1, 0, 0), 8);
            Debug.Log("Rotate up because slider value has increased");
            ypreviousslidervalue = yslidervalue;
            Debug.Log("previousslidervalue is now" + ypreviousslidervalue);
        }

        else if (yslidervalue < ypreviousslidervalue)
        {
            transform.Rotate(new Vector3(1, 0, 0), 8);
            Debug.Log("Rotate down because slider value has decreased");
            ypreviousslidervalue = yslidervalue;
            Debug.Log("previousslidervalue is now" + ypreviousslidervalue);
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}