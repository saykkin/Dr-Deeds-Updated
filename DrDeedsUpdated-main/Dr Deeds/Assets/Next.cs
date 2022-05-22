using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{

    public float wait_time = 16f;

    void Start()
    {
        StartCoroutine(Wait_for_past());
    }

    IEnumerator Wait_for_past()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene(3);

    }

}
