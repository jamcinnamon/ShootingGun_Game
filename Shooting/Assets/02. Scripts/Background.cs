using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Background : MonoBehaviour
{
    public float scrollspeed = 0.2f;
    public Material bgMaterial;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * scrollspeed * Time.deltaTime;
    }
}
