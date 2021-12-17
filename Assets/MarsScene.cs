using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarsScene : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("SolarSystem");
    }
}