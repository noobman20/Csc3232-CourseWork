using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapcoller : MonoBehaviour {

    private GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(player.transform.position.x, 18f, player.transform.position.z);
	}
}
