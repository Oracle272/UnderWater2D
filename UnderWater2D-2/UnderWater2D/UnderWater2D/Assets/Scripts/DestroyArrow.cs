using UnityEngine;
using System.Collections;

public class DestroyArrow : MonoBehaviour
{

    public float theDelay = 2.0f;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, theDelay);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }
    }
}
