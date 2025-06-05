//좀비를 움직이게하는 스크립트
using UnityEngine;

public class ZombieMagnetFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 2.5f; //디폴트속도
    private bool canMove = false;
    private float delayTime = 6f; //6초 뒤에 좀비가 움직임
    private float timer = 0f;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            target = playerObj.transform; // 플레이어를 향해 움직인다

        string difficulty = PlayerPrefs.GetString("Difficulty", "Normal");
        switch (difficulty) // 난이도별 속도
        {
            case "Easy": speed = 1.5f; break; 
            case "Normal": speed = 2.5f; break;
            case "Hard": speed = 3.5f; break;
        }
    }

    void Update()
    {
        // 게임 끝났으면 이동 중단
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
            return;

        if (!canMove)
        {
            timer += Time.deltaTime;
            if (timer >= delayTime)
                canMove = true;
            else
                return;
        } // 일정 시간 동안 이동을 막음

        if (target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized; // 위치 방향계산
        transform.position += direction * speed * Time.deltaTime; // 속도 대상 방향 이동
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
            return;

        // target이랑 충돌한 경우만 처리
        if (collision.gameObject == target)
        {
            Debug.Log("좀비한테 잡혔다");
            GameManager.Instance.GameOver(); // 좀비에게 잡힌 경우
        }
    }

}


