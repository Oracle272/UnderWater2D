using UnityEngine;
using System.Collections;

public class CameraTransition : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject Target;
    [SerializeField]
    private GameObject Camera;
    	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        Camera.transform.position = Vector3.MoveTowards(Camera.transform.position, Target.transform.position, step);
        Camera.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y, -10);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ocean")
        {
           Target = col.gameObject;
        }
    }

}
