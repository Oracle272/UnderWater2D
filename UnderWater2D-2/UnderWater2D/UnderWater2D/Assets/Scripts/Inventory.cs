using UnityEngine;
using UnityEngine.UI;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Inventory : MonoBehaviour
{


    public GameObject MaceButton;
    public GameObject BowButton;
    public GameObject Mace;
    public GameObject Bow;
    // Use this for initialization
    void Start()
    {
       
        Mace.SetActive(false);
        Bow.SetActive(false);
        BowButton.SetActive(false);
        MaceButton.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void bag() 
    {
        //BowButton.SetActive(true);
        //MaceButton.SetActive(true);
        BowButton.SetActive(!BowButton.activeSelf);
        MaceButton.SetActive(!MaceButton.activeSelf);
    }

    public void SelectMace()
    {
        Bow.SetActive(false);
        Mace.SetActive(true);
    }

    public void SelectBow()
    {
        Bow.SetActive(true);
        Mace.SetActive(false);
    }
}
