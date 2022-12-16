using UnityEngine;

// Purpose: control sprites
[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    // sets a color
    public void ChangeRendererColor(ColorID obj)
    {
        // refers to ColorID script > value indexed
        rendererObj.color = obj.value;
    }
}
