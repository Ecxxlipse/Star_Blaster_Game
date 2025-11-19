using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] Vector2 movespeed;

    Vector2 offset;
    Material material;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        offset += movespeed * Time.deltaTime;
        material.mainTextureOffset = offset;
    }
}
