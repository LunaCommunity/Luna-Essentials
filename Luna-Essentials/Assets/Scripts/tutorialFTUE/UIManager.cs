using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("---- Data Container ----")]
    public ScriptableUIData endData;

    [Header("---- Texts ----")]
    public Text intrsutionText;

    public Text winText;
    public Text descriptionText;
    public Text installText;

    [Header("---- Image/Sprites ----")]
    public Image profile;
    
    [Header("---- Other ----")]
    public GameObject end;
    public GameObject start;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        //StartPanel data assignment
        intrsutionText.text = endData.startInstruction;

        //EndPanel data assignment
        winText.text = endData.title_Text;
        descriptionText.text = endData.description_text;

        installText.text = endData.install_CTA_BTN;
        profile.sprite = endData.endcard_IMG;

    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SwitchPanel();
        }
    }

    public void SwitchPanel()
    {
        start.SetActive(false);
        end.SetActive(true);
    }
}