using UnityEngine;
//���� ��������ϴ� ��� �� �浹�ϰ� �ϴ� ���

public class Mine : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; //���� �̹���
    private Collider2D col; //�浹�ϰ� �ϴ� ���
    private float timer = 5f;//5�� �ڿ� �����

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //��������ϴ±��
        col = GetComponent<Collider2D>(); //�����浹
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f && spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false; // ���ڴ� �� ���̰��Ѵ�. �ð��� ������ ���ڴ� �������
            // ���ڸ� ������� �浹�� �����ȴ�
        }
    }
}
