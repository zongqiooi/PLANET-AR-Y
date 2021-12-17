﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SatelliteScene : MonoBehaviour
{
    // Start is called before the first frame update    
    void Start() { }

    // Update is called once per frame    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "Cloudsat")
                {
                    SceneManager.LoadScene("CloudsatInfo");
                }
                else if (hit.transform.name == "Jason")
                {
                    SceneManager.LoadScene("JasonInfo");
                }
            }
        }
    }
}