using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void SceneChanger(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Single);
    }
}

