using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Correction de la faute d'orthographe ici

public class Transition : MonoBehaviour
{
    public string SceneName;

    public void ChangeScene() // Correction de la faute d'orthographe ici
    {
        SceneManager.LoadScene(SceneName); // Correction de la faute d'orthographe ici
    }
}
