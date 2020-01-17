using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScence : MonoBehaviour
{
    public void LoadScnce(string SceneName)
    {
        SceneManager.LoadScene(SceneName);//loading the scence useing unity scene manager added to the main camera aswell
    }
}
