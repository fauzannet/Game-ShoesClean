using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class utama : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void mulaigame()
    { SceneManager.LoadScene("game"); }
}
