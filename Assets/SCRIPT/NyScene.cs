using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// SceneManagement behövdes för att kunna använda sig av flera Scenes i form av "SceneManager" Class och "LoadScene" function och kommer användas vilket inte var jätte kul att leta runt på internetet för...
/// </summary>

public class NyScene : MonoBehaviour
{
    public void BytScene(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}