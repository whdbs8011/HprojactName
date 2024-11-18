using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpSqure2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(scene),2f);
    }

    void scene()
    {
        SceneManager.LoadScene("Scenes/sky block");
    }
}
