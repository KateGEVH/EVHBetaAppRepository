using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueButtonScript : MonoBehaviour
{

    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
