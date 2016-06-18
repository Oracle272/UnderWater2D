using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour {
    public GameObject player;
    public Transform playerspawn;
	// Use this for initialization
	void Start () {
	}
	
    void Awake()
    {
        DontDestroyOnLoad(player);
       
    }
    // Update is called once per frame
    void Update () {
	
	}

    void OnLevelWasLoaded()
    {
        player.transform.position = playerspawn.position;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "toOcean")
        {
            SceneManager.LoadScene("OpenOcean");
        }

        else if (col.gameObject.tag == "toHouse")
        {
            SceneManager.LoadScene("PlayerHouse");
        }
    }
}
