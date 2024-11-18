using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(scene), 15f);
    }

    void scene()
    {
        SceneManager.LoadScene("Scenes/StartRoom");
    }
}
