using UnityEngine;

public class ShrinkAndDestroy : MonoBehaviour
{
    public float shrinkRate = 0.1f;  // Скорость уменьшения

    void Update()
    {
        // Уменьшение объекта
        transform.localScale -= Vector3.one * shrinkRate * Time.deltaTime;

        // Проверка, если размер достиг или меньше 0
        if (transform.localScale.x <= 0f || transform.localScale.y <= 0f || transform.localScale.z <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
