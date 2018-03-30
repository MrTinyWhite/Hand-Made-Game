using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	private void Start()
	{
        RandomGeneratePosition();
	}

	public void RandomGeneratePosition()
    {
        float pos_y = Random.Range(-0.3f, 0.03f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, pos_y, this.transform.localPosition.z);//localposition是本地坐标，position是世界坐标
    }

	void OnTriggerExit(Collider other)
	{
        if(other.tag == "Player")
        {
            GameManager._instance.score++;
            this.GetComponent<AudioSource>().Play();
        }
	}



	void OnGUI()
	{
        GUILayout.Label("Score:" + GameManager._instance.score);
	}
}
