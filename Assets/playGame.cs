using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void gameplay() {
        SceneManager.LoadScene(1);
    }
}