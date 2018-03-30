using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBird : MonoBehaviour {


    private GameObject bird;
    private Transform birdTransform;

    // Use this for initialization
	void Start () {
        bird = GameObject.FindGameObjectWithTag("Player");
        birdTransform = bird.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 birdPos = birdTransform.position;
        float y = birdPos.y - 3.57f;
        if (y > 2.5f)
            y = 2.5f;
        if (y < -2.5f)
            y = -2.5f;
        this.transform.position = new Vector3(birdPos.x + 0.6899996f, y , -10);
	}
}
