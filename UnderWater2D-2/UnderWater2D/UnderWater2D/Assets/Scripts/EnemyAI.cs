using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private  Rigidbody2D Enemy;
    private Transform target;
    bool inRange = false;
    
    public float speed = 1.0f;
    public float rotationSpeed = 1.0f;
    public float detectionRange = 10;
    private int directionPicker;
    public float timer = 0.0f; // how long it will go in the direction
    public float thrust = 5.0f;
    private Vector3 v_diff;


    void Start()
    {
        Enemy = GetComponent<Rigidbody2D>();
    
    }

    void Update()
    {
        // if not in range
        if (inRange == false)
        {
            if (timer <= Time.time)
            {
                timer = Time.time + Random.Range(4, 10);
                directionPicker = Random.Range(1, 5);
                Direction();
            }
        }
        //if in range
        if (inRange == true)
        {
            transform.LookAt(target.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation
                                                                
            if (Vector3.Distance(transform.position, target.position) > 1f)
            {//move if distance from target is greater than 1
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            inRange = true;
            target = col.gameObject.transform;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            inRange = false;
        }
    }


    void Direction()
    {
        if (directionPicker == 1)
        {
            Enemy.AddForce(-transform.up * thrust);
        }
        else if (directionPicker == 2)
        {
            Enemy.AddForce(transform.up * thrust);
        }
        else if (directionPicker == 3)
        {
            Enemy.AddForce(transform.right * thrust);
        }
        else if (directionPicker == 4)
        {
            Enemy.AddForce(-transform.right * thrust);
        }
    }
}

