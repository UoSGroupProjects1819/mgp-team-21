using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

    public static void GameStart(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }
}
