﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public GameObject panel;

    public void Open()
    {
        panel.SetActive(true);
    }
    public void Close()
    {
        panel.SetActive(false);
    }
}
