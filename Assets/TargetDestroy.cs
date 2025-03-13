using UnityEngine;

public class TargetDestroy : MonoBehaviour
{
    public GameObject particlesDestroy; // Эффект разрушения
    public TargetCounter targetCounter; // Ссылка на TargetCounter

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obj"))
        {
            Destroy(other.gameObject); // Уничтожаем объект, который столкнулся

            // Вызываем метод NewTarget из скрипта SpawnTarget
            transform.parent.GetComponent<SpawnTarget>().NewTarget();

            // Создаём эффект разрушения
            Instantiate(particlesDestroy, transform.position, transform.rotation);

            // Уничтожаем текущую мишень
            Destroy(gameObject);

            // Увеличиваем счётчик
            targetCounter.IncrementTargetCount();
        }
    }
}
