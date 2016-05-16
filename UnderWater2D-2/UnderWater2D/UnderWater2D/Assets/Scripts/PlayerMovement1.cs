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

    // Update is called once per frame
    //void Update () {

    //       if (SwipeManager.SwipeDirection == Swipe.Up)
    //       {
    //           PlayerBody.AddForce(new Vector2(0, speed*Time.deltaTime), ForceMode2D.Force);
    //           // do something...
    //       }

    //       if (SwipeManager.SwipeDirection == Swipe.Down)
    //       {
    //           PlayerBody.AddForce(new Vector2(0, -speed*Time.deltaTime), ForceMode2D.Force);
    //           Debug.Log("Moving Down");
    //           // do something...
    //       }

    //       if (SwipeManager.SwipeDirection == Swipe.Left)
    //       {
    //           PlayerBody.AddForce(new Vector2(-speed*Time.deltaTime, 0), ForceMode2D.Force);
    //           // do something...
    //       }

    //       if (SwipeManager.SwipeDirection == Swipe.Right)
    //       {
    //           PlayerBody.AddForce(new Vector2(speed*Time.deltaTime, 0), ForceMode2D.Force);
    //           // do something...
    //       }

    //       if (SwipeManager.SwipeDirection == Swipe.DownLeft)
    //       {
    //           PlayerBody.AddForce(new Vector2(-speed * Time.deltaTime, -speed * Time.deltaTime), ForceMode2D.Force);

    //       }
    //       if (SwipeManager.SwipeDirection == Swipe.DownRight)
    //       {
    //           PlayerBody.AddForce(new Vector2(speed * Time.deltaTime, -speed * Time.deltaTime), ForceMode2D.Force);

    //       }
    //       if (SwipeManager.SwipeDirection == Swipe.UpLeft)
    //       {
    //           PlayerBody.AddForce(new Vector2(-speed * Time.deltaTime, speed * Time.deltaTime), ForceMode2D.Force);

    //       }
    //       if (SwipeManager.SwipeDirection == Swipe.UpLeft)
    //       {
    //           PlayerBody.AddForce(new Vector2(speed * Time.deltaTime, speed * Time.deltaTime), ForceMode2D.Force);

    //       }

    //   }

    public float RotationSpeed = 15f;

    public void Update()
    {
        var horizontalMovement = CnInputManager.GetAxis("Horizontal");
        var verticalMovement = CnInputManager.GetAxis("Vertical");
        PlayerBody.AddForce(new Vector2(horizontalMovement * Time.deltaTime*speed, verticalMovement * Time.deltaTime*speed), ForceMode2D.Force);

        // OriginTransform.Rotate(Vector3.up, horizontalMovement * Time.deltaTime * RotationSpeed);
    }

}
