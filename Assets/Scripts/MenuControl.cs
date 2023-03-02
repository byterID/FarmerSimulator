using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject SettingsButton;
    Animator anim;
    public GameObject ARCam1;
    public GameObject ARsession1;
    public GameObject ARCam2;
    public GameObject ARsession2;
    public GameObject Butt1;
    public GameObject Butt2;


    public void Start()
    {
        
    }
    public void ShowSettings()
    {
        anim = GetComponent<Animator>();
        anim.Play("Show");
        SettingsButton.SetActive(false);
    }
    public void CloseSettings()
    {
        anim = GetComponent<Animator>();
        anim.Play("Hide");
        SettingsButton.SetActive(true);
    }
    public void SupportBoxActive()
    {
        ARCam1.SetActive(false);
        ARsession1.SetActive(false);
        Butt1.SetActive(false);
        ARCam2.SetActive(true);
        ARsession2.SetActive(true);
        Butt2.SetActive(true);
    }
    public void PlacementActive()
    {
        ARCam2.SetActive(false);
        ARsession2.SetActive(false);
        Butt2.SetActive(false);
        ARCam1.SetActive(true);
        ARsession1.SetActive(true);
        Butt1.SetActive(true);
    }
}
