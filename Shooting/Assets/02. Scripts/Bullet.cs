using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Speed of the bullet
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� (�̷�) ��ġ = ���� (����) ��ġ + ---
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
    }
}
