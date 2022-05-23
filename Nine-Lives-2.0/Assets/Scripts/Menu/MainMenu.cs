using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Settings;
    [SerializeField] private GameObject AboutUs;
    [SerializeField] private GameObject Contact;

    private string tecMenu = "Menu";

    private void Update()
    {
        if (tecMenu == "Menu")
        {

        }

        else if (tecMenu == "Settings")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitSettings();
                LoadMenu();
            }
        }

        else if (tecMenu == "AboutUs")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitAboutUs();
                LoadSettings();
            }
        }

        else if (tecMenu == "Contact")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitContact();
                LoadSettings();
            }
        }
    }

    public void NewGame ()
    {
        SceneManager.LoadScene("night");
    }

    public void LoadMenu ()
    {
        Menu.SetActive(true);
    }

    public void ExitMenu()
    {
        Menu.SetActive(false);
    }

    public void LoadSettings()
    {
        tecMenu = "Settings";
        Settings.SetActive(true);
    }

    public void ExitSettings ()
    {
        Settings.SetActive(false);
        tecMenu = "Menu";
    }

    public void LoadAboutUs()
    {
        tecMenu = "AboutUs";
        AboutUs.SetActive(true);
    }

    public void ExitAboutUs()
    {
        AboutUs.SetActive(false);
        tecMenu = "Settings";
    }
    public void LoadContact()
    {
        tecMenu = "Contact";
        Contact.SetActive(true);
    }

    public void ExitContact()
    {
        Contact.SetActive(false);
        tecMenu = "Settings";
    }

    public void ExitGame()
    {
        Debug.Log("bye");
        Application.Quit();
    }
}
