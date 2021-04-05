using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {

        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(2);
    }
}
