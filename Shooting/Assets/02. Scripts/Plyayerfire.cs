using UnityEngine;

public class Plyayerfire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject gun;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1")) // ctrl or mouse left click
        {
            GameObject bullet = Instantiate(bulletFactory);
            // ���� �Ⱥ��̴� �Ӽ�(����) ����־�ߵ� �׸� ���� �׸��� ���忡�� �Ѿ� ����
            bullet.transform.position = gun.transform.position; ;
            // �Ѿ��� ��ġ���� ���� ��ġ������ ������
        }
    }
}
