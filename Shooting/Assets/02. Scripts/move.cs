using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5;
    // private float float speed = 5; 인스펙터에 뜨지 않게 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //인생주기 태어나게 하는 1번 호출
    {
        
    }

    // Update is called once per frame . pc에 따라 1초에 다르게 업데이트(계속 호출) 
    void Update()
    {

         // 우1 아래-1
        float h = Input.GetAxis("Horizontal"); // -1  1
        float v = Input.GetAxis("Vertical");  //  -1  1

        // 방향
        Vector3 dir = Vector3.right * h + Vector3.up  * v;
        //            Vector3(1,0,0) *1  + Vector3(0,1,0) * -1
        //            Vector3(1,0,0)     + Vector3(0,-1,0)
        //            Vector3(1,-1,0)  

        // Vector3 dir = new Vector3(h, v, 0); 캐릭터는 3차원. 3차원으로 움직이는 캐릭터가 아니기 때문에 z값 0.

        transform.position = transform.position + dir * speed * Time.deltaTime;

    }
}
