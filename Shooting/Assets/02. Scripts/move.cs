using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5;
    // private float float speed = 5; �ν����Ϳ� ���� �ʰ� 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //�λ��ֱ� �¾�� �ϴ� 1�� ȣ��
    {
        
    }

    // Update is called once per frame . pc�� ���� 1�ʿ� �ٸ��� ������Ʈ(��� ȣ��) 
    void Update()
    {

         // ��1 �Ʒ�-1
        float h = Input.GetAxis("Horizontal"); // -1  1
        float v = Input.GetAxis("Vertical");  //  -1  1

        // ����
        Vector3 dir = Vector3.right * h + Vector3.up  * v;
        //            Vector3(1,0,0) *1  + Vector3(0,1,0) * -1
        //            Vector3(1,0,0)     + Vector3(0,-1,0)
        //            Vector3(1,-1,0)  

        // Vector3 dir = new Vector3(h, v, 0); ĳ���ʹ� 3����. 3�������� �����̴� ĳ���Ͱ� �ƴϱ� ������ z�� 0.

        transform.position = transform.position + dir * speed * Time.deltaTime;

    }
}
