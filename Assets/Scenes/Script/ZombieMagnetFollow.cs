//���� �����̰��ϴ� ��ũ��Ʈ
using UnityEngine;

public class ZombieMagnetFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 2.5f; //����Ʈ�ӵ�
    private bool canMove = false;
    private float delayTime = 6f; //6�� �ڿ� ���� ������
    private float timer = 0f;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            target = playerObj.transform; // �÷��̾ ���� �����δ�

        string difficulty = PlayerPrefs.GetString("Difficulty", "Normal");
        switch (difficulty) // ���̵��� �ӵ�
        {
            case "Easy": speed = 1.5f; break; 
            case "Normal": speed = 2.5f; break;
            case "Hard": speed = 3.5f; break;
        }
    }

    void Update()
    {
        // ���� �������� �̵� �ߴ�
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
            return;

        if (!canMove)
        {
            timer += Time.deltaTime;
            if (timer >= delayTime)
                canMove = true;
            else
                return;
        } // ���� �ð� ���� �̵��� ����

        if (target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized; // ��ġ ������
        transform.position += direction * speed * Time.deltaTime; // �ӵ� ��� ���� �̵�
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
            return;

        // target�̶� �浹�� ��츸 ó��
        if (collision.gameObject == target)
        {
            Debug.Log("�������� ������");
            GameManager.Instance.GameOver(); // ���񿡰� ���� ���
        }
    }

}


