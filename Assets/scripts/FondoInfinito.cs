using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
  
public float velocidad = 5f;
    public float multiplicador = 1f;

    private float anchoSprite;

    void Start()
    {
        anchoSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.Translate(Vector2.left * velocidad * multiplicador * Time.deltaTime);

        if (transform.position.x <= -anchoSprite)
        {
            transform.position += new Vector3(anchoSprite * 2f, 0f, 0f);
        }
    }
}
