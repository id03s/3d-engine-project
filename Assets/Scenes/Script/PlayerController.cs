using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mine"))
        {
            Debug.Log("���� ��Ҵ�! �÷��̾� �����!");

            // ĳ���� ������� �ϱ�
            Destroy(gameObject);
        }
        if (other.CompareTag("Zombie"))
        {
            Debug.Log("�������� ������");

            // ĳ���� ������� �ϱ�
            Destroy(gameObject);
        }
    }
}
