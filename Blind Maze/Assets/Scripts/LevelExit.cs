using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Reflection;

public class LevelExit : MonoBehaviour
{
    int NLUsed = 0;
    public int Level;

    private void Start()
    {
        if (NLUsed >= 250)
        {
            EditorApplication.isPaused = true;
        }
        Level = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            NextLevel();
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(Level);
        NLUsed += 1;
        Debug.Log("the method" + MethodBase.GetCurrentMethod() + "has Been Used:" + NLUsed);
        return;
    }
}
