using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    public GameObject G1info;
    public GameObject G2info;
    public GameObject G3info;
    public GameObject G4info;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void G1boxEnable()
    {
        G1info.SetActive(true);
    }
    public void G1boxDisbale()
    {
        G1info.SetActive(false);
    }

    public void G2boxEnable()
    {
        G2info.SetActive(true);
    }
    public void G2boxDisbale()
    {
        G2info.SetActive(false);
    }

    public void G3boxEnable()
    {
        G3info.SetActive(true);
    }
    public void G3boxDisbale()
    {
        G3info.SetActive(false);
    }

    public void G4boxEnable()
    {
        G4info.SetActive(true);
    }
    public void G4boxDisbale()
    {
        G4info.SetActive(false);
    }

    public void BuyG1()
    {
        Application.OpenURL("https://www.google.com");
    }
    public void BuyG2()
    {
        Application.OpenURL("https://www.google.com");
    }
    public void BuyG3()
    {
        Application.OpenURL("https://www.google.com");
    }

}
