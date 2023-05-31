using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// SceneManagement beh�vdes f�r att kunna anv�nda sig av flera Scenes i form av "SceneManager" Class och "LoadScene" function och kommer anv�ndas vilket inte var j�tte kul att leta runt p� internetet f�r...
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