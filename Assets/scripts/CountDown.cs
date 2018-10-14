using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(CD());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CD()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = 18 + "";
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Text>().text = 15 + "";
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Text>().text = 12 + "";
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Text>().text = 9 + "";
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = 3+"";
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = 2 + "";
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = 1 + "";
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Text>().text = 0 + "";
        SceneManager.LoadScene("city");
    }
}

