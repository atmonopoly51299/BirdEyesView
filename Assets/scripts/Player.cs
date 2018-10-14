using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        //gameObject.GetComponent<Button>().onClick.AddListener(OPS);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OPS()
    {
        SceneManager.LoadScene("deforestation");
        Debug.Log("aaa");
    }
}
