﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsMenuController : MonoBehaviour
{
    public GameObject mainMenu;

    
    public void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameObject.SetActive(false);
                mainMenu.SetActive(true);
}

    }
}
