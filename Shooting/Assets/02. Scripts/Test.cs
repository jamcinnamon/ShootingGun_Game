using System.Runtime.CompilerServices;
using UnityEngine;   // import UnityEngine 네임스페이스를 사용하여 Unity의 기능을 사용할 수 있게 합니다.

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("나는 스타트"); // UnityEngine.Debug.Log를 사용하여 로그를 출력합니다.
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("나는 업데이트");
    }

    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("온트리거엔터 충돌 감지됨: " + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("온콜리전엔터 충돌 감지됨: " + collision.gameObject.name);
    }
}