using System;
using System.Collections;
using System.Collections.Generic;
using Michsky.UI.ModernUIPack;
using UnityEngine;
using UnityEngine.Serialization;

public class VideoController : MonoBehaviour
{
    
    [FormerlySerializedAs("ResolutionDropdown")] public CustomDropdown resolutionDropdown;
    public SwitchManager fullScreenToggle;

    private AudioSource click;

    private void Start()
    {
        click = GetComponent<AudioSource>();
        SetFullSizeUI();
        //SetScreenSizeUI();
    }
    
    public void SetFullScreen()
    {
        click.Play();
        Screen.fullScreen = !Screen.fullScreen;
    }


    public void SetResolution(int resolutionIndex)
    {
        Managers.Settings.settings.screenSize = resolutionDropdown.dropdownItems[resolutionIndex].itemName;
        int width = int.Parse(resolutionDropdown.dropdownItems[resolutionIndex].itemName.Split('x')[0]);
        int height = int.Parse(resolutionDropdown.dropdownItems[resolutionIndex].itemName.Split('x')[1]);

        Managers.Settings.settings.resolutionIndex = resolutionIndex;
        
        Screen.SetResolution(width, height, Screen.fullScreen);
    }

    // private void SetScreenSizeUI()
    // {
    //     int resolutionIndex = Managers.Settings.settings.resolutionIndex;
    //     
    //     int width = int.Parse(resolutionDropdown.dropdownItems[resolutionIndex].itemName.Split('x')[0]);
    //     int height = int.Parse(resolutionDropdown.dropdownItems[resolutionIndex].itemName.Split('x')[1]);
    //
    //     //Set correct resolution?? needs Tests
    // }
    
    /// <summary>
    /// Устанавливаем тогле на старте в правильное положение
    /// </summary>
    private void SetFullSizeUI()
    {
        Screen.fullScreen = Managers.Settings.settings.fullScreen;
        fullScreenToggle.isOn = Managers.Settings.settings.fullScreen;
    }
}
