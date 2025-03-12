using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] GameObject gameoverScreen;
    private Rigidbody2D rb;
    public GameManager gameManager;
    public AudioManager audioManager;
    private bool canMove;
    private bool isDead;
    void Start()
    {
        canMove = true;
        isDead = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canMove)
        {
            rb.linearVelocity = Vector2.up * force;
        }
        if(transform.position.y < -5.5f || transform.position.y > 5.6)
        {
            die();
        }

        float angle = Mathf.Atan2(rb.linearVelocityY, 20f) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pipe"))
        {
            die();
        }
        else if(collision.CompareTag("CheckPoint"))
        {
            audioManager.playSFX(audioManager.pointClip);
            gameManager.addScore(1);
        }
    }

    private void die()
    {
        if (isDead) return;

        isDead = true;
        canMove = false;
        gameoverScreen.SetActive(true);
        audioManager.playSFX(audioManager.gameOverClip);
        audioManager.StopMusic();
    }
}
