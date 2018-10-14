using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiper : MonoBehaviour {
    private Vector2 direction;
    private float speed = 0.2f;

    public GameObject player;

    public float backSpeed = 2000f;

    private Vector3 pivot;

    // Use this for initialization
    void Start () {
        pivot = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Moved)//Check if Touch has moved.
        {
            //if (Input.touches[0].deltaPosition.magnitude > 10)
            //{
                direction = Input.touches[0].deltaPosition / 10;  
                //Unit Vector of change in position
                                                                 
                //speed = Input.touches[0].deltaPosition.magnitude / Input.touches[0].deltaTime; //distance traveled divided by time elapsed
                                                                 
                //player.transform.position += new Vector3(direction.x, direction.y) * speed;
                         
                //player.GetComponent<Rigidbody>().AddForce(direction * Time.deltaTime * speed);
                player.transform.position = Vector3.Lerp(player.transform.position, player.transform.position + new Vector3(direction.x, direction.y, 0), 0.5f * Time.deltaTime * 10f);

            //}
        } else
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, pivot, 0.5f * Time.deltaTime * 10f);
        }
    }
}
