using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCombat : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
     int sharkdmgAmount = 2;
     int piranhadmgAmount = 1;
     int octopusdmgAmount = 3;
     int barracudadmgAmount = 3;
     int jellyfishdmgAmount = 5;


    // Use this for initialization
    void Start () {
	
	}
	
    void Awake()
    {
        currentHealth = startingHealth;
    }
	// Update is called once per frame
	void Update () {
	
        if(currentHealth <= 0)
        {
            //gameover
        }

	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Shark")
        {
            Debug.Log("Collided");
            currentHealth -= sharkdmgAmount;
            healthSlider.value = currentHealth;
        }

       else if(col.gameObject.name == "Piranhas")
        {
            Debug.Log("CollidedPiranha");
            currentHealth -= piranhadmgAmount;
            healthSlider.value = currentHealth;

        }
        else if (col.gameObject.name == "Octopus")
        {
            
            currentHealth -= octopusdmgAmount;
            healthSlider.value = currentHealth;

        }
        else if (col.gameObject.name == "Barracuda")
        {
            
            currentHealth -= barracudadmgAmount;
            healthSlider.value = currentHealth;

        }
        else if (col.gameObject.name == "Jellyfish")
        {
           
            currentHealth -= jellyfishdmgAmount;
            healthSlider.value = currentHealth;

        }
        else if (col.gameObject.name == "Bomb")
        {

            currentHealth -= 10;
            healthSlider.value = currentHealth;
            //play explosion particle effect

        }
        else if(col.gameObject.tag == "SeaWeed")
        {
            currentHealth += 10;
            healthSlider.value = currentHealth;
            Destroy(GameObject.FindGameObjectWithTag("SeaWeed"));
        }
    }
}
