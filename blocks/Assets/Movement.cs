using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector2 PosPlayer;
    [SerializeField] float speed = 10f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TestMove();
    }


    public void OnMove(InputValue value)
    {
        PosPlayer = value.Get<Vector2>();
        // posPlayer.y = value.gameobject.position.y;
        // PosPlayer.x = value.GameObject.position.x;
        Debug.Log(PosPlayer);
    }
    void TestMove()
    {
        Vector2 PlayerSpeed = new Vector2(PosPlayer.x * speed, rb.linearVelocity.y);
        rb.linearVelocity = PlayerSpeed;
    }
}
