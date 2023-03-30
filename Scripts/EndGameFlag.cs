using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameFlag : MonoBehaviour
{
    //public void EndGameMenu()
    //{
    //    SceneManager.LoadScene(2);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Test()
    {
        print("Test Succesfull");
    }
}
