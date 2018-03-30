using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrigger : MonoBehaviour {

    public Transform currentBg;

    public void OnTriggerEnter(Collider other)
	{
        //print("OnTriggerEnter");
        if(other.tag == "Player")
        {
            //将bg移动到第一个位置
            Transform firstBg = GameManager._instance.firstBg;
            currentBg.transform.position = new Vector3(firstBg.position.x + 10, this.transform.position.y, this.transform.position.z);
            GameManager._instance.firstBg = currentBg;

        }

	}
}
