using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D door)
    {
        if (door.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
