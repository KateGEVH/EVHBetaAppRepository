using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPointTextActivatorScript : MonoBehaviour
{
    public GameObject touchpoint;
    public GameObject textpopup;
    public Button closebtn;


    //Start is called before the first frame update

    void Start()
    {

        closebtn.GetComponent<Button>();
        closebtn.onClick.AddListener(ClosePopUp);
    }

    private void OnMouseDown()
    {
        
        textpopup.SetActive(true);
        Debug.Log("The sphere has been clicked");
    }

    public void ClosePopUp()
    {
        textpopup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
