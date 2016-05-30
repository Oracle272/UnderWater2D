using UnityEngine;
using System.Collections;

public class BowAndArrow : MonoBehaviour
{


    public Rigidbody2D arrow;
    public Transform BowMiddle;
    public int force;
    bool canAttack = true;
    // Use this for initialization
    void Start()
    {


    }

    void OnEnable()
    {
        canAttack = true;
    }
    IEnumerator WaitToShoot()
    {
        canAttack = false;
        Rigidbody2D arrowInstance;
        arrowInstance = Instantiate(arrow, BowMiddle.position, BowMiddle.rotation) as Rigidbody2D;
        arrowInstance.AddForce(-BowMiddle.right * force);
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
    }
    // Update is called once per frame
    void Update()
    {

        



    }

    public void Attack()
    {
        if (canAttack == true)
        {
            StartCoroutine(WaitToShoot());
            //playAnim
        }
    }



}
