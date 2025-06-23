using UnityEngine;
// ź���ϴ� ���� �߿��� 30�� ������ �÷��̾� �������� ���ƿ��� ����ź ó�� ���� �ϴ� �� 
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Vector3 dir; // dir ����

    public GameObject explosionFactory; // ���� ����Ʈ ������
    void Start()
    {
        int ranValue = Random.Range(0, 10);
        if(ranValue < 3)// 0, 1, 2�� �÷��̾� �������� ���ƿ���
        {
            GameObject player = GameObject.Find("Player");

            // ������ �÷��̾�� ���� �ڽ��� ��ġ���� �÷��̾��� ��ġ�� �� ���ͷ� ����
            dir = player.transform.position - transform.position;
            dir.Normalize(); // ���� ���͸� ����ȭ�Ͽ� ���̸� 1�� ����ϴ�. �ӵ��� �����ϰ� ���⸸ ����.
            transform.position = transform.position + dir * speed * Time.deltaTime;
            //transform.position += dir * speed * Time.deltaTime; �ٿ�����
        }
        else
        {
            dir = Vector3.down; // �⺻������ �Ʒ��� �������� ����
        }
    }

    void Update()
    {
        //Vector3 dir = Vector3.down; // dir ����
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory); // ���� ����Ʈ ����
        explosion.transform.position = transform.position; // ���� ����Ʈ ��ġ�� ���� ��ġ�� ����

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
