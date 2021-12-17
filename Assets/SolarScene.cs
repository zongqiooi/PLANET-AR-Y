using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolarScene : MonoBehaviour
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
                if (hit.transform.name == "Mars")
                {
                    SceneManager.LoadScene("MarsInfo");
                }
                else if (hit.transform.name == "Mercury")
                {
                    SceneManager.LoadScene("MercuryInfo");
                }
                else if (hit.transform.name == "Venus")
                {
                    SceneManager.LoadScene("VenusInfo");
                }
                else if (hit.transform.name == "Earth")
                {
                    SceneManager.LoadScene("EarthInfo");
                }
                else if (hit.transform.name == "Jupiter")
                {
                    SceneManager.LoadScene("JupiterInfo");
                }
                else if (hit.transform.name == "Saturn")
                {
                    SceneManager.LoadScene("SaturnInfo");
                }
                else if (hit.transform.name == "Uranus")
                {
                    SceneManager.LoadScene("UranusInfo");
                }
                else if (hit.transform.name == "Neptune")
                {
                    SceneManager.LoadScene("NeptuneInfo");
                }
                else if (hit.transform.name == "Moon")
                {
                    SceneManager.LoadScene("MoonInfo");
                }
                else if (hit.transform.name == "Sun")
                {
                    SceneManager.LoadScene("SunInfo");
                }
            }
        }
    }
}