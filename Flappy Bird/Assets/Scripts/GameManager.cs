using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    public static int GAMESTATE_MENU = 0;   //开始时小鸟的状态
    public static int GAMESTATE_PLAYING = 1;    //玩游戏时的状态
    public static int GAMESTATE_END = 2;    //游戏结束时的状态


    public Transform firstBg;
    public int score = 0;
    public int GameState = GAMESTATE_MENU;
    public static GameManager _instance;

    private GameObject bird;

	void Awake()
	{
        _instance = this;
        bird = GameObject.FindGameObjectWithTag("Player");
	}


	private void Update()
	{
        if(GameState == GAMESTATE_MENU)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameState = GAMESTATE_PLAYING;
                bird.GetComponent<Rigidbody>().useGravity = true;
                bird.GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);
            }
        }

	}
}
