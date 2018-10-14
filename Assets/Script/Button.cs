using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Button : MonoBehaviour
{

    // Use this for initialization

    public void ButtonAction() {
        Debug.Log("aaaa");
        SceneManager.LoadScene("deforestation");
    }

}
