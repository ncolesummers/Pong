using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Help Script is used to toggle the help menu on and off
/// </summary>
public class Help : MonoBehaviour
{
    public GameObject helpUI;
    /// <summary>
    /// Start is called before the first frame update. Hides the help menu.
    /// </summary>
    void Start()
    {
        helpUI.SetActive(false);
    }
    
    /// <summary>
    /// Update is called once per frame. Toggles the help menu on and off when the H key is pressed.
    /// </summary>
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            ToggleHelp();
        }
    }
    
    /// <summary>
    /// Toggles the help menu on and off
    /// </summary>
    void ToggleHelp()
    {
        helpUI.SetActive(!helpUI.activeSelf);
        if (helpUI.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
