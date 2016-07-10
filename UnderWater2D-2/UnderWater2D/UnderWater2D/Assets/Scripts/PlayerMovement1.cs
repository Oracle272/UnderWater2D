using CnControls;
using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour {


    public Rigidbody2D PlayerBody;
    public float speed = 0.5f;
    public float MaxTargetDistance = 2.0f;
    public GameObject target;

    // Use this for initialization
    void Start () {
        PlayerBody = GetComponent<Rigidbody2D>();
	}

    public float RotationSpeed = 15f;

    public void Update()
    {

         if (Input.GetMouseButtonDown(0))
        { 
                         //Converting Mouse Pos to 2D (vector2) World Pos
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
                         if (hit.transform.gameObject.tag == "Enemys")
                target = hit.transform.gameObject;
                Debug.Log(hit.transform.name);
                             }
                  }

 
      public void FixedUpdate()
      {

        var horizontalMovement = CnInputManager.GetAxis("Horizontal");
        var verticalMovement = CnInputManager.GetAxis("Vertical");
        PlayerBody.AddForce(new Vector2(horizontalMovement * Time.deltaTime*speed, verticalMovement * Time.deltaTime*speed), ForceMode2D.Force);
                 if (!target)
                     {
                         //code below makes the player rotate in the direction
            var dir = GetComponent<Rigidbody2D>().velocity;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            var q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, RotationSpeed * Time.deltaTime);
                         /*The code above is used to make it so the player rotates in the direction that it is moving*/
                     }
                 if (target)
                     {
                         if (Vector3.Distance(this.transform.position, target.transform.position) > MaxTargetDistance)
                             {
                target = null;
                             }
            Vector3 vectorToTarget = target.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
                     }

    }

}
