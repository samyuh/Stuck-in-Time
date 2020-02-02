using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;
    public bool jumpAllowed;
    public Vector3 spawnPoint;
    Rigidbody2D rb;

    [SerializeField] float base_gravity_scale = 3;
    [SerializeField] float fall_multiplier = 2f;
    [SerializeField] float not_jumping_multiplier = 2.5f;

    [SerializeField] float minx;
    [SerializeField] float maxx;
    [SerializeField] float miny;
    [SerializeField] float maxy;


    public bool facingRight = true;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        ShesDead();
        if (Input.GetKeyDown(KeyCode.Space) && jumpAllowed)
        {
            SoundManagerScript.PlaySound("jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            jumpAllowed = false;
        }
        else if(!Input.GetKey(KeyCode.Space) && !jumpAllowed)
        {

            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale * not_jumping_multiplier;
        }

        if (!jumpAllowed && rb.velocity.y < -0.001f)
        {
            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale * fall_multiplier;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector2(0, 0);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector2(0, 180);
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else rb.velocity = new Vector2(0, rb.velocity.y);
}

    void ShesDead()
    {
        if(gameObject.transform.position.x < minx || gameObject.transform.position.x > maxx || gameObject.transform.position.y < miny || gameObject.transform.position.y > maxy)
        {
            this.transform.position = spawnPoint;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.gameObject.CompareTag("ground") && !jumpAllowed)
        {
            Debug.Log("A");
            SoundManagerScript.PlaySound("hit");
            GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale;
            jumpAllowed = true;
        }
    }

    //void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("ground") && jumpAllowed)
    //    {
    //        GetComponent<Rigidbody2D>().gravityScale = base_gravity_scale;
    //        jumpAllowed = false;
    //    }
    //}

    void FlipPlayer()
    {
        facingRight = !facingRight;

        Vector2 localScale = gameObject.transform.localScale;

        localScale.x *= -1;

        transform.localScale = localScale;

    }
}
