using UnityEngine;
using System.Collections;

public class Mace : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Attack()
    {
        GetComponent<Animation>().Play();
    }
}
