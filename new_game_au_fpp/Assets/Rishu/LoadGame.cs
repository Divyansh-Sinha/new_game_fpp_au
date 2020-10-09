using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Game");
    }
}
