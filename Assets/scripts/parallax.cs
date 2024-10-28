
using UnityEngine;

public class background : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float animationspeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
    }
}
