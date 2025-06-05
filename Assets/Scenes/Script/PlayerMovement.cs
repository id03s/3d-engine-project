//�÷��̾��� �������� ����ϴ� ��ũ��Ʈ
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;// ĳ���Ͱ� �����̴� �ӵ�
    private Rigidbody2D rb;
    private Vector2 movement;

    private bool canMove = false;
    private float delayTime = 5f; //5�ʵڿ� �����δ�
    private float timer = 0f;

    private GameManager gm; // GameManager ����

    public static bool isCleared = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = Object.FindFirstObjectByType<GameManager>(); // �ֽ� ������� ����
    }

    void Update()
    {
        if (!canMove)
        {
            timer += Time.deltaTime;
            if (timer >= delayTime)
                canMove = true;
            else
                return; // ����ð����� �������� ���Ѵ�
        }

        // �̵� �Է� �ޱ�(�̵�Ű)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate() // �̵������� ���¿� �����̱�
    {
 
        if (canMove)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        } //5�ʰ� ������ ������ �� �ִ�.
    }

    void OnTriggerEnter2D(Collider2D other) //���α����� ���� ����
    {
        if (other.CompareTag("Goal")) //������� ���� ���
        {
            Debug.Log("����!");
        }
        else if (other.CompareTag("Zombie") || other.CompareTag("Mine")) //���񿡰� ���ϰų� ���ڸ� ���� ���
        {
            gm?.GameOver(); // Game Over ���� 
        }
    }
}

