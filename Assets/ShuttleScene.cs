using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShuttleScene : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Rocket");
    }
}