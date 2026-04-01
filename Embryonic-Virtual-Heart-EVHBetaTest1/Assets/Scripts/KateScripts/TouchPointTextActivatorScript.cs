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
        if (openpopup1 != null && openpopup1.activeSelf)
            openpopup1.SetActive(false);

        if (openpopup2 != null && openpopup2.activeSelf)
            openpopup2.SetActive(false);

        if (openpopup3 != null && openpopup3.activeSelf)
            openpopup3.SetActive(false);

        if (openpopup4 != null && openpopup4.activeSelf)
            openpopup4.SetActive(false);

        if (openpopup5 != null && openpopup5.activeSelf)
            openpopup5.SetActive(false);

        if (openpopup6 != null && openpopup6.activeSelf)
            openpopup6.SetActive(false);

        if (openpopup7 != null && openpopup7.activeSelf)
            openpopup7.SetActive(false);

        if (openpopup8 != null && openpopup8.activeSelf)
            openpopup8.SetActive(false);

        if (openpopup9 != null && openpopup9.activeSelf)
            openpopup9.SetActive(false);

        if (openpopup10 != null && openpopup10.activeSelf)
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
