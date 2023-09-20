using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGlasses : MonoBehaviour
{
    public GameObject glasses1;
    public GameObject glasses2;
    public GameObject glasses3;
    public GameObject glasses4;

    Button glasses1button;
    Button glasses2button;
    Button glasses3button;
    Button glasses4button;

    // Start is called before the first frame update
    void Start()
    {
        glasses1button = GameObject.Find("Canvas/glasses1button").GetComponent<Button>();
        glasses2button = GameObject.Find("Canvas/glasses2button").GetComponent<Button>();
        glasses3button = GameObject.Find("Canvas/glasses3button").GetComponent<Button>();
        glasses4button = GameObject.Find("Canvas/glasses4button").GetComponent<Button>();

        glasses1button.onClick.AddListener(Glasses1Selected);
        glasses2button.onClick.AddListener(Glasses2Selected);
        glasses3button.onClick.AddListener(Glasses3Selected);
        glasses4button.onClick.AddListener(Glasses4Selected);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Glasses1Selected()
    {
        glasses1.SetActive(true);
        glasses2.SetActive(false);
        glasses3.SetActive(false);
        glasses4.SetActive(false);
    }
    public void Glasses2Selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(true);
        glasses3.SetActive(false);
        glasses4.SetActive(false);
    }
    public void Glasses3Selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(false);
        glasses3.SetActive(true);
        glasses4.SetActive(false);
    }
    public void Glasses4Selected()
    {
        glasses1.SetActive(false);
        glasses2.SetActive(false);
        glasses3.SetActive(false);
        glasses4.SetActive(true);
    }

}
