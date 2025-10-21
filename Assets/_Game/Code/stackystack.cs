using UnityEngine;

public class stackystack : MonoBehaviour
{
    private SpriteRenderer pstack;
    public float stacksize = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pstack = GetComponent<SpriteRenderer>();
        pstack.drawMode = SpriteDrawMode.Tiled;
    }

    // Update is called once per frame
    void Update()
    {
        pstack.size = new Vector2(1, GameManager.instance.score);
    }
}
