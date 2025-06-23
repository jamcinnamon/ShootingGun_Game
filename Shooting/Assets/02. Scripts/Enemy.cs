using UnityEngine;
// 탄생하는 적들 중에서 30퍼 정도는 플레이어 방향으로 날아오게 유도탄 처럼 가게 하는 것 
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir; // dir 방향

    public GameObject explosionFactory; // 폭발 이펙트 프리팹
    void Start()
    {
        int ranValue = Random.Range(0, 10);
        if(ranValue < 3)// 0, 1, 2는 플레이어 방향으로 날아오게
        {
            GameObject player = GameObject.Find("Player");

            // 방향은 플레이어에게 가되 자신의 위치에서 플레이어의 위치를 뺀 벡터로 설정
            dir = player.transform.position - transform.position;
            dir.Normalize(); // 방향 벡터를 정규화하여 길이를 1로 만듭니다. 속도는 유지하고 방향만 설정.
            transform.position = transform.position + dir * speed * Time.deltaTime;
            //transform.position += dir * speed * Time.deltaTime; 줄여쓰기
        }
        else
        {
            dir = Vector3.down; // 기본적으로 아래로 떨어지게 설정
        }
    }

    void Update()
    {
        //Vector3 dir = Vector3.down; // dir 방향
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory); // 폭발 이펙트 생성
        explosion.transform.position = transform.position; // 폭발 이펙트 위치를 적의 위치로 설정

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
