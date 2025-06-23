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
        // random �ϰ� ������ �������� ����ó�� 0�ʷ� �ٽ� �ΰ� ����
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
