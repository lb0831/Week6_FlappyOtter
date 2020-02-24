using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
   public void Redo()
    {
        SceneManager.LoadScene("Brown_Scene");
        Time.timeScale = 1;
    }
}
