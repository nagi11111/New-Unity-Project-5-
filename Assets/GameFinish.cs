﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour {

    public void Onclick()
    {
        SceneManager.LoadScene("Title");
    }
}