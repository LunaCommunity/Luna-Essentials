using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This example supports both TMP, and Unity.UI Text, however can just be adjusted to use one or the other

public class FontChanger : MonoBehaviour
{
    //This is used for ease of access as you might have texts inside of prefabs that need to be changed
    //if you can, feel free to instead cache a reference for this class where ever you need to change fonts
    public static FontChanger Instance;

    
    /// <summary>
    /// fontSelection - enum for changing language, will be visible in playground once luna is installed and the LunaPlaygroundField line uncommented
    /// fontsTMP - holds tmp fonts for each language in the same order as the fontSelection enum (assigned in inspector)
    /// fontDictTMP - converts the fontsTMP list into a dictionary for fast access
    /// fontsText - holds normal fonts (non TMP font atlases) for each language in the same order as the fontSelection enum (assigned in inspector) 
    /// fontsDictText - converts the fontsText list into a dictionary for fast access
    /// </summary>
    
    //Un-comment once you have Luna installed to make this available in Playground
    // [LunaPlaygroundField("Fonts", 0, "Font Settings")] 
    [SerializeField] private FontsTypes fontSelection;
    
    [Header("---- TMP Font ----")]
    [SerializeField] private List<TMP_FontAsset> fontsTMP = new List<TMP_FontAsset>();
    private Dictionary<FontsTypes, TMP_FontAsset> fontDictTMP = new Dictionary<FontsTypes, TMP_FontAsset>();
    
    [Header("---- Text Font ----")]
    
    [SerializeField] private List<Font> fontsText = new List<Font>();
    private Dictionary<FontsTypes, Font> fontsDictText = new Dictionary<FontsTypes, Font>();
    
    
    void Awake()
    {
        Instance = this;
        //Add the TMP and normal fonts to their respective dictionaries which will be the same order as the list
       for (var i = 0; i < fontsTMP.Count; i++)
       {
           fontDictTMP.Add((FontsTypes)i, fontsTMP[i]);
       }
       for (var i = 0; i < fontsText.Count; i++)
       {
           fontsDictText.Add((FontsTypes)i, fontsText[i]);
       }
    }

    //methods returns either tmp font asset or text font asset
    public TMP_FontAsset GetFontTMP() => fontDictTMP[fontSelection];
    public Font GetFontText() => fontsDictText[fontSelection];
}

//The FontTypes enum index should correspond to the order of the fonts you assign to the FontsText/FontsTMP array.
//If you dont have the Fonts in the list to match the languages in FontTypes index, Unity will throw an error.
[System.Serializable]
public enum FontsTypes
{
    English = 0,
    Japanese = 1,
    //Korean = 2,
    //ChineseSC = 3,
    //ChineseTC = 4,
    
}
