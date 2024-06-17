using UnityEngine;

public class DeleteOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
//Cкрипт удаляет по нажатию любой объект (любой объект на который повешен данный скрипт)