using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour {
    public Texture[] texture;
    public RawImage raw;
    public Text pointTime;
    private int hitcount = 0, point=0;


    public Texture bird;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void Update()
    {
        StartCoroutine(Timerr());
        if (point >= 1200)
        {
            SceneManager.LoadScene("entercity");
            raw.texture = bird;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ++hitcount;
        if (hitcount == 4)
        {
            pointTime.text += " DIED! BUT LET'S KEEP ON TO SHOW THE CONCEPT";
            raw.texture = texture[hitcount - 1];
        }
        else if (hitcount > 0 && hitcount < 4)
        {
            raw.texture = texture[hitcount - 1];
        }
    }
    IEnumerator Timerr()
    {
        yield return new WaitForSeconds(1f);
        ++point;
        pointTime.text = point + " pts";
        if (point != 0 && point % 5 == 0 && hitcount>0)
        {
            --hitcount;
        }
    }
}
