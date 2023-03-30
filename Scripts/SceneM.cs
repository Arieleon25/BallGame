using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(1);
    }


    //public void EndScene()
    //{
    //    SceneManager.LoadScene(2);
    //    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}


    public void SceneMenu()
    {
        SceneManager.LoadScene(0);
    }
}

