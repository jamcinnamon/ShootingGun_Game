using System.Runtime.CompilerServices;
using UnityEngine;   // import UnityEngine ���ӽ����̽��� ����Ͽ� Unity�� ����� ����� �� �ְ� �մϴ�.

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("���� ��ŸƮ"); // UnityEngine.Debug.Log�� ����Ͽ� �α׸� ����մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("���� ������Ʈ");
    }

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("��Ʈ���ſ��� �浹 ������: " + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("���ݸ������� �浹 ������: " + collision.gameObject.name);
    }
}