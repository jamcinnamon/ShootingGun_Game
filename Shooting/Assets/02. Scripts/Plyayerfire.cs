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
            // 눈에 안보이는 속성(변수) 담고있어야될 그릇 생성 그리고 공장에서 총알 생산
            bullet.transform.position = gun.transform.position; ;
            // 총알의 위치값은 총의 위치값으로 가져와
        }
    }
}
