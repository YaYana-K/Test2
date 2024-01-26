using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float interactionRadius = 1f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // Визначення вектора руху
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Нормалізація вектора для уникнення додаткової швидкості при руху по діагоналі
        movement.Normalize();

        transform.position += movement * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.TryGetComponent<IHintContainer>(out IHintContainer hintContainer))
        {
            //hintContainer?.
        }
    }
}
