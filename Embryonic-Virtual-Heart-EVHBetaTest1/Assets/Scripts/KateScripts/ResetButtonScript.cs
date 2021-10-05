using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{
    public Button resetbtn;
    public Slider yslider;
    public Slider xslider;

    // Start is called before the first frame update
    void Start()
    {
        resetbtn.GetComponent<Button>();
        resetbtn.onClick.AddListener(Resetfxn);
        yslider.GetComponent<Slider>();
        xslider.GetComponent<Slider>();
    }

    public void Resetfxn()
    {
        gameObject.transform.SetPositionAndRotation(new Vector3(0, 125, -275), Quaternion.Euler(new Vector3(0, 0, 0)));
        //-318 is so that the empty parent is far enough back that the model doesn't pop out past the canvas
        yslider.value = 0;
        xslider.value = 0;


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
