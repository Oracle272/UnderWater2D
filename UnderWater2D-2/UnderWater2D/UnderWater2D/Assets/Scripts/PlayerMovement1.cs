using CnControls;
using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour {


    public Rigidbody2D PlayerBody;
    public float speed = 0.5f;
	// Use this for initialization
	void Start () {
        PlayerBody = GetComponent<Rigidbody2D>();
	}

    public float RotationSpeed = 15f;

    public void Update()
    {
        var horizontalMovement = CnInputManager.GetAxis("Horizontal");
        var verticalMovement = CnInputManager.GetAxis("Vertical");
        PlayerBody.AddForce(new Vector2(horizontalMovement * Time.deltaTime*speed, verticalMovement * Time.deltaTime*speed), ForceMode2D.Force);


        var dir = GetComponent<Rigidbody2D>().velocity;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        var q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, RotationSpeed * Time.deltaTime);
        /*The code above is used to make it so the player rotates in the direction that it is moving*/
    }

}
