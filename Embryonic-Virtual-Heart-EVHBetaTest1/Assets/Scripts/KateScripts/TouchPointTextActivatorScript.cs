using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPointTextActivatorScript : MonoBehaviour
{
    public GameObject touchpoint;
    public GameObject textpopup;
    public Button closebtn;
    public GameObject openpopup1;
    public GameObject openpopup2;
    public GameObject openpopup3;
    public GameObject openpopup4;
    public GameObject openpopup5;
    public GameObject openpopup6;
    public GameObject openpopup7;
    public GameObject openpopup8;
    public GameObject openpopup9;
    public GameObject openpopup10;


    //Start is called before the first frame update

    void Start()
    {

        closebtn.GetComponent<Button>();
        closebtn.onClick.AddListener(ClosePopUp);
    }

    private void OnMouseDown()
    {
        if (openpopup1 == isActiveAndEnabled)
            openpopup1.SetActive(false);

        if (openpopup2 == isActiveAndEnabled)
            openpopup2.SetActive(false);

        if (openpopup3 == isActiveAndEnabled)
            openpopup3.SetActive(false);

        if (openpopup4 == isActiveAndEnabled)
            openpopup4.SetActive(false);

        if (openpopup5 == isActiveAndEnabled)
            openpopup5.SetActive(false);

        if (openpopup6 == isActiveAndEnabled)
            openpopup6.SetActive(false);

        if (openpopup7 == isActiveAndEnabled)
            openpopup7.SetActive(false);

        if (openpopup8 == isActiveAndEnabled)
            openpopup8.SetActive(false);

        if (openpopup9 == isActiveAndEnabled)
            openpopup9.SetActive(false);

        if (openpopup10 == isActiveAndEnabled)
            openpopup10.SetActive(false);

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
