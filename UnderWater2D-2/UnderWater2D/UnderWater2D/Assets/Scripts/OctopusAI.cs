using UnityEngine;
using System.Collections;

public class OctopusAI : MonoBehaviour {

    private Rigidbody2D Enemy;
    private Transform target;
    bool inRange = false;
    public GameObject ink;
    public Transform inkSpawn;
    public float speed = 1.0f;
    public float rotationSpeed = 1.0f;
    public float detectionRange = 10;
    private int directionPicker;
    public float timer = 0.0f; // how long it will go in the direction
    public float thrust = 5.0f;
    public int force;
    bool canAttack = true;



    void Start()
    {
        Enemy = GetComponent<Rigidbody2D>();

    }
    void OnEnable()
    {
        canAttack = true;
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

        if(inRange == true)
        {
            canAttack = true;
        }
        if (canAttack == true)
        {
            StartCoroutine(WaitToShoot());
            //playAnim
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            inRange = true;
            target = col.gameObject.transform;
            Debug.Log("in");
        }
    }
   
    IEnumerator WaitToShoot()
    {
        canAttack = false;
        Rigidbody2D inkInstance;
        inkInstance = Instantiate(ink, inkSpawn.position, inkSpawn.rotation) as Rigidbody2D;
        inkInstance.AddForce((target.position - transform.position) * force);
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
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
