using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataBlock", menuName = "data")]
public class ScriptableUIData : ScriptableObject
{
    /// <summary>
    ///Un-comment the LunaPlaygroundField attributes once Luna is installed to avoid errors
    /// </summary>
    
    [Header(("Game start UI settings"))]
    // [LunaPlaygroundField("Instruction Text", 1, "End Screen")]
    public string startInstruction;
    
    
    [Header(("End Card UI Settings"))]
    // [LunaPlaygroundField("CTA Text", 2, "End Screen")]
    public string install_CTA_BTN;
    // [LunaPlaygroundField("Game title", 3, "End Screen")]
    public string title_Text;
    // [LunaPlaygroundField("Label Text", 4, "End Screen")]
    public string description_text;
    
    // [LunaPlaygroundAsset("End Card Image",5, "End Screen")]
    public Sprite endcard_IMG;
  

}
/*
Add and remove fields from here to be referenced in the UI Manager.
The fields can be assigned from the inspector.
*/