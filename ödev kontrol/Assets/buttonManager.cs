using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{
    UIManager UIManager_sc;
    public InputField nameInput;
    public GameObject menuPanel,gamePanel;
    private void Awake()
    {
        try
        {
            UIManager_sc = FindObjectOfType<UIManager>();
            nameInput = GameObject.Find("nameInput").GetComponent<InputField>();
        }
        catch
        {

        }
    }
    
    public void ONAYButton()
    {
        UIManager_sc.userName = nameInput.text;
        menuPanel.SetActive (false);

    }

    
}
