using UnityEngine;
//지뢰 사라지게하는 기능 및 충돌하게 하는 기능

public class Mine : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; //지뢰 이미지
    private Collider2D col; //충돌하게 하는 기능
    private float timer = 5f;//5초 뒤에 사라짐

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //사라지게하는기능
        col = GetComponent<Collider2D>(); //물리충돌
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f && spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false; // 지뢰는 안 보이게한다. 시간이 지나면 지뢰는 사라진다
            // 지뢰만 사라지지 충돌은 유지된다
        }
    }
}
