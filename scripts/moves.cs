using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moves : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rb;
    bool alive = true;

    void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (!alive) return;

        if (Time.timeScale == 1f)
        {
            Score.inst.increase();
        }
        animator.SetBool("run", true);
        transform.Translate(0f, 0f, 2f * Time.timeScale);


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("jump", true);
            animator.SetBool("up", true);
            animator.SetBool("run", false);
        }
        else
        {
            animator.SetBool("jump", false);
            animator.SetBool("up", false);
            animator.SetBool("run", true);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1f, 0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            Time.timeScale = 0f;
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            Time.timeScale = 1f;
        }

        if (transform.position.x<-500 || transform.position.x > 500)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Die();
        }
    }
}
