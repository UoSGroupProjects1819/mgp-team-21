using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchMenus : MonoBehaviour
{
    public Button BackButton;
    public Button SettingsButton;
    public bool MenuIsActive = false;

    public GameObject MainMenuUI;
    public GameObject SettingsMenuUI;

    private void Start()
    {
        Button btn1 = BackButton.GetComponent<Button>();
        btn1.onClick.AddListener(ToggleMainMenu);

        Button btn2 = BackButton.GetComponent<Button>();
        btn2.onClick.AddListener(ToggleSettings);


    }

    public void Update()
    {
        if (MenuIsActive == false)
        {
            ToggleSettings();
        }
        else
        {
            ToggleMainMenu();
        }
    }

    void ToggleMainMenu()
    {
        SettingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        MenuIsActive = true;
        

        MainMenuUI.SetActive(true);
    }
    void ToggleSettings()
    {
        MainMenuUI.SetActive(false);
        Time.timeScale = 1f;
        MenuIsActive = false;
        

        SettingsMenuUI.SetActive(true);
    }
}
