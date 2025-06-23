using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float createTime;
    private float currentTime;
    public GameObject enemyFactory;

    public float minTime = 1;
    public float maxTime = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // random 하게 나오고 떨어지고 리셋처럼 0초로 다시 두고 랜덤
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;

            createTime = Random.Range(minTime, maxTime);
        }
    }
}
