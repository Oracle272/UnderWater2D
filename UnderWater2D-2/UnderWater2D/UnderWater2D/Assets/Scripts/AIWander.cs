using UnityEngine;
using System.Collections;

public class AIWander : MonoBehaviour
{ 
    public Rigidbody2D loneWanderer;
    private int directionPicker;
    public float timer = 0.0f; // how long it will go in the direction
    public float thrust = 5.0f;

    void Start()
    {
        loneWanderer = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (timer <= Time.time)
        {

            timer = Time.time + Random.Range(4, 10);
            //timer = Time.time + 4.0f;
            directionPicker = Random.Range(1, 5);
            Direction();
        }
    }



    void Direction()
    {
        if(directionPicker == 1)
        {
            loneWanderer.AddForce(-transform.up * thrust);
        }
       else if (directionPicker == 2)
        {
            loneWanderer.AddForce(transform.up * thrust);
        }
        else if (directionPicker == 3)
        {
            loneWanderer.AddForce(transform.right * thrust);
        }
        else if (directionPicker == 4)
        {
            loneWanderer.AddForce(-transform.right * thrust);
        }
    }

}

