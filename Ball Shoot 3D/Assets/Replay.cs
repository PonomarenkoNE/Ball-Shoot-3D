using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        print("suka");
        SceneManager.LoadScene("Game");
    }
}
