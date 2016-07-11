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
    public GameObject bagimage;
    public GameObject maceCheck;
    public GameObject bowCheck;
    public GameObject macePic;
    public GameObject bowPic;
    public bool paused;
    bool MaceEquiped;
    bool BowEquipped;

    // Use this for initialization
    void Start()
    {
       
        Mace.SetActive(false);
        Bow.SetActive(false);
        BowButton.SetActive(false);
        MaceButton.SetActive(false);
        maceCheck.SetActive(false);
        macePic.SetActive(false);
        bowCheck.SetActive(false);
        bowPic.SetActive(false);
        bagimage.SetActive(false);
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
            
    }

    public void bag() 
    {
        paused = !paused;
        //BowButton.SetActive(true);
        //MaceButton.SetActive(true);
        BowButton.SetActive(!BowButton.activeSelf);
        MaceButton.SetActive(!MaceButton.activeSelf);
        bagimage.SetActive(!bagimage.activeSelf);
        if(MaceEquiped == true)
        {
            maceCheck.SetActive(!maceCheck.activeSelf);
            BowEquipped = false;
        }
        if(BowEquipped == true)
        {
            bowCheck.SetActive(!bowCheck.activeSelf);
            MaceEquiped = false;
        }
        //maceCheck.SetActive(!maceCheck.activeSelf);
        //macePic.SetActive(!macePic.activeSelf);
        //bowCheck.SetActive(!bowCheck.activeSelf);
        //bowPic.SetActive(!bowPic.activeSelf);
    }

    public void SelectMace()
    {
        Bow.SetActive(false);
        Mace.SetActive(true);
        maceCheck.SetActive(true);
        bowCheck.SetActive(false);
        MaceEquiped = true;
    }

    public void SelectBow()
    {
        Bow.SetActive(true);
        Mace.SetActive(false);
        maceCheck.SetActive(false);
        bowCheck.SetActive(true);
        BowEquipped = true;
    }
}
