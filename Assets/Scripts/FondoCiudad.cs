using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float backgroundWidth; // Ancho de tu sprite (en unidades Unity)

    void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Mueve el fondo hacia la izquierda
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // Si el fondo sale completamente de la pantalla, reposiciónalo
        if (transform.position.x < -backgroundWidth)
        {
            Vector2 resetPosition = new Vector2(backgroundWidth * 2f, transform.position.y);
            transform.position = resetPosition;
        }
    }
}