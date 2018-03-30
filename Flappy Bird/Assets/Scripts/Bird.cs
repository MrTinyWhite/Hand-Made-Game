using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public int frameCount = 0;//frame counter = 3
    public int frameNumber = 10;//每秒显示的帧数
    public float timer;

    public bool animation = false;//是否播放飞行的动画
    public bool canJump = false;


	// Use this for initialization
	void Start () {
       // this.GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

    //    Vector3 vel = this.GetComponent<Rigidbody>().velocity;
      //  this.GetComponent<Rigidbody>().velocity = new Vector3(5, vel.y, vel.z);


        //动画
        if(GameManager._instance.GameState == GameManager.GAMESTATE_PLAYING)
        {
            timer += Time.deltaTime;
            if (timer >= 1.0f / frameNumber)
            {
                frameCount++;
                timer -= 1.0f / frameNumber;
                int frameIndex = frameCount % 3;

                this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.3333333f * frameIndex, 0));//MainTex，主图片

            } 
        }


        //控制进行跳跃
        if(GameManager._instance.GameState == GameManager.GAMESTATE_PLAYING)
        {
            if(Input.GetMouseButtonDown(0))//左鼠标按下
        {

                this.GetComponent<AudioSource>().Play();
                Vector3 vel2 = this.GetComponent<Rigidbody>().velocity;
                this.GetComponent<Rigidbody>().velocity = new Vector3(vel2.x, 5, vel2.z);
        }
        
        }


	}

   
}
