﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNonVRScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;

    // Switches to MainScene on button click
    void Start()
    {
        LoadLevel();
        SceneManager.LoadSceneAsync("NonVRScene");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
