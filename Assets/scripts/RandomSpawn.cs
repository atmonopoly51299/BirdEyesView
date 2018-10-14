using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject[] gos;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Copy", 1.0f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Copy()
    {
        for(int i = 0; i < gos.Length; ++i)
        {
            GameObject mGameObject = Instantiate(gos[i], new Vector3(Random.Range(-20.0f, 20.0f), gos[i].transform.localPosition.y, gos[i].transform.localPosition.z),gos[i].transform.rotation);
            mGameObject.AddComponent<Move>();
        }
    }
}
