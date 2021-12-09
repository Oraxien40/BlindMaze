using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerKill"))
        {
            Die();
        }
    }

    void Die()
    {
        rigidbody.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
