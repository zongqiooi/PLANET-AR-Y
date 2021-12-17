using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Solar()
    {
        SceneManager.LoadScene("SolarSystem");
    }
    public void Rocket()
    {
        SceneManager.LoadScene("Rocket");
    }
    public void Rover()
    {
        SceneManager.LoadScene("Rover");
    }
    public void Satellite()
    {
        SceneManager.LoadScene("Satellite");
    }
    public void Suit()
    {
        SceneManager.LoadScene("Suit");
    }
    public void Menu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}