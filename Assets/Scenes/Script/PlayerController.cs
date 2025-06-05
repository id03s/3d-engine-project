using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mine"))
        {
            Debug.Log("지뢰 밟았다! 플레이어 사라짐!");

            // 캐릭터 사라지게 하기
            Destroy(gameObject);
        }
        if (other.CompareTag("Zombie"))
        {
            Debug.Log("좀비한테 잡혔다");

            // 캐릭터 사라지게 하기
            Destroy(gameObject);
        }
    }
}
