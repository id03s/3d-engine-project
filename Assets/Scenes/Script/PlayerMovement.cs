//플레이어의 움직임을 담당하는 스크립트
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;// 캐릭터가 움직이는 속도
    private Rigidbody2D rb;
    private Vector2 movement;

    private bool canMove = false;
    private float delayTime = 5f; //5초뒤에 움직인다
    private float timer = 0f;

    private GameManager gm; // GameManager 참조

    public static bool isCleared = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = Object.FindFirstObjectByType<GameManager>(); // 최신 방식으로 참조
    }

    void Update()
    {
        if (!canMove)
        {
            timer += Time.deltaTime;
            if (timer >= delayTime)
                canMove = true;
            else
                return; // 경과시간동안 움직이지 못한다
        }

        // 이동 입력 받기(이동키)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate() // 이동가능한 상태에 움직이기
    {
 
        if (canMove)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        } //5초가 지나면 움직일 수 있다.
    }

    void OnTriggerEnter2D(Collider2D other) //골인구간에 들어가면 골인
    {
        if (other.CompareTag("Goal")) //결승점을 밟은 경우
        {
            Debug.Log("골인!");
        }
        else if (other.CompareTag("Zombie") || other.CompareTag("Mine")) //좀비에게 당하거나 지뢰를 밟은 경우
        {
            gm?.GameOver(); // Game Over 실행 
        }
    }
}

