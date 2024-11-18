using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pushTheButton : MonoBehaviour
{
    private bool isCollising;

    IEnumerator OnCollising()
    {
        isCollising = true;
        while (isCollising)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Scenes/flat");
                yield break;
            }

            yield return null;
        }
    }

    private void ExitCollising()
    {
        isCollising = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(OnCollising());
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ExitCollising();
        }
    }


    // private void OnCollisionStay(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         Debug.Log("버튼을 누를수 있습니다.");
    //         if (Input.GetKeyDown(KeyCode.E))
    //         {
    //             SceneManager.LoadScene("Scenes/flat");
    //         }
    //     }
    // }
}

