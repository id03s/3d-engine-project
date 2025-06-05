//게임의 전반적인 동작 
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // 싱글턴 패턴을 위한 static 인스턴스

    public GameObject gameOverText;
    public GameObject gameClearText;
    // 게임오버, 게임클리어

    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;
    //게임상태 플래그

    public GameObject[] zombies;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject); // 중복 방지
    }
    // 게임 매니저가 처음 생성 될 때 싱글턴 설정

    private void Start() 
    {
        isGameOver = false; // 게임 오버 상태 초기화
        Time.timeScale = 1f; // 게임 시간 정상 속도로 설정
    }

    public void GameOver() // 게임 오버 처리 함수
    {
        if (isGameOver) return; //이미 오버 상태면 무시

        isGameOver = true; // 게임 오버 상태 설정
        gameOverText.SetActive(true); // 게임오버 ui표시
        Time.timeScale = 0f; //게임정지
    }

    public void GameClear() // 게임 클리어 처리 함수
    {  
        if (isGameOver) return; //이미 오버상태면 무시

        isGameOver = true; //게임 오버 상태 설정
        gameClearText.SetActive(true); //게임 클리어 ui 표시

        foreach (GameObject z in zombies) //좀비들의 추적 기능 비활성화
        { 
            ZombieMagnetFollow zmf = z.GetComponent<ZombieMagnetFollow>();
            if (zmf != null)
                zmf.enabled = false;
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) //플레이어 태그 및 충돌 비활성화
        {
            player.tag = "Untagged";

            Collider2D col = player.GetComponent<Collider2D>();
            if (col != null)
                col.enabled = false;
        }

        Time.timeScale = 0f; //게임 정지
    }

    // 카운트다운 후 호출됨 게임 스타트 호출
    public void StartGame()
    {
        isGameOver = false;
        Time.timeScale = 1f;
        Debug.Log("게임 시작됨 (StartGame 호출됨)");
    }
}

