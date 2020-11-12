using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSettings : MonoBehaviour
{
    //Add TMP texts and Unity.UI texts for each text asset in game that needs to be localised.
   [Header("---- UI TMP Texts ----")]
    public TMP_Text[] UI_TMP;
    
    [Header("---- UI Texts ----")]
    public Text[] UI_Text;

    //Loop through the two arrays and set the font of each text component
    void Start()
    {
        for (int i = 0; i < UI_TMP.Length; i++)
        {
            UI_TMP[i].font = FontChanger.Instance.GetFontTMP();
        }
        for (int i = 0; i < UI_Text.Length; i++)
        {
            UI_Text[i].font = FontChanger.Instance.GetFontText();
        }
    }
    
}
