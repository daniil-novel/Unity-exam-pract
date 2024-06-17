using UnityEngine;

public class VectorMovement : MonoBehaviour
{
    public float speed = 5f;  // Скорость передвижения

    void Update()
    {
        // Получение ввода по осям
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Создание вектора движения на основе ввода
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Перемещение объекта
        transform.position += movement * speed * Time.deltaTime;
    }
}
