using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 0.15f, fadeAmount = 2;
    // Use this for initialization
    void Start () {
        //gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.a, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.2f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += Vector3.forward * speed;
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.2f);
        //gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, fadeAmount + (0.01f * Time.deltaTime)); ;
    }
}
