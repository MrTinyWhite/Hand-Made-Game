using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeUpOrDown : MonoBehaviour {


    public AudioSource hitMusic;
    public AudioSource dieMusic;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager._instance.GameState = GameManager.GAMESTATE_END;
          
            hitMusic.Play();
            dieMusic.Play();
        }
    }
}
