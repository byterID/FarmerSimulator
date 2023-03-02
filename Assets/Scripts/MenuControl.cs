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
        SceneManager.LoadScene("SupportBoxScene");
    }
    public void PlacementActive()
    {
        SceneManager.LoadScene("PlacementScene");
    }
}
