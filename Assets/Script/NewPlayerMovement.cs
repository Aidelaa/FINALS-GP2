using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public int KalatCount;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;
    public string GameCompleteScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * MoveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Kalat"))
        {
            KalatCount++;
            Destroy(collision.gameObject);
        }

        GameOver();
    }
    void GameOver()
    {
        if (KalatCount == 22)
        {
            SceneManager.LoadScene(GameCompleteScene);
        }
    }
}
