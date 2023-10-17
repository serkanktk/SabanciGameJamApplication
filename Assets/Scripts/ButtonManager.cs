using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonManager : MonoBehaviour
{
    public GameObject CongText;
    public GameObject CongButton;

    public GameObject NothingText;
    public GameObject NeverButton;

    public void yesButtonOnTriggerEnter()
    {
        CongText.SetActive(false);
        CongButton.SetActive(false);

        NothingText.SetActive(true);
        NeverButton.SetActive(true);
    }

    public void neverButtonOnTriggerEnter()
    {
    #if UNITY_EDITOR
        // Close the game if it's being played from the editor
        EditorApplication.isPlaying = false;
    #else
        // Close the game if it's a built application
        Application.Quit();
    #endif
    }

}
