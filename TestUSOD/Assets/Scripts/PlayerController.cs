using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float interactionRadius = 1f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // ���������� ������� ����
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // ����������� ������� ��� ��������� ��������� �������� ��� ���� �� �������
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
