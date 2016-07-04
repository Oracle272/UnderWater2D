using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour {
    public GameObject player;
    public Transform playerspawn;
    private int prevLevel;
    private int level;
    public Transform[] PosiblePositions;
    
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
        player.transform.position = PosiblePositions[prevLevel].transform.position;

        prevLevel = level;

        switch (level)
        {
            case 0:
                player.transform.position = PosiblePositions[0].transform.position;
                break;
            case 1:
                player.transform.position = PosiblePositions[1].transform.position;
                break;
            case 2:
                player.transform.position = PosiblePositions[2].transform.position;
                break;
            case 3:
                player.transform.position = PosiblePositions[3].transform.position;
                break;
            case 4:
                player.transform.position = PosiblePositions[4].transform.position;
                break;
            case 5:
                player.transform.position = PosiblePositions[5].transform.position;
                break;
            case 6:
                player.transform.position = PosiblePositions[6].transform.position;
                break;
            case 7:
                player.transform.position = PosiblePositions[7].transform.position;
                break;
        }
    }


    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if(col.gameObject.tag == "toOcean")
    //    {
    //        SceneManager.LoadScene("OpenOcean");
    //    }

    //    else if (col.gameObject.tag == "toHouse")
    //    {
    //        SceneManager.LoadScene("PlayerHouse");
    //    }
    //}
}
