using UnityEngine;
using UnityEngine.UI; // Для работы с UI

public class TargetCounter : MonoBehaviour
{
    public Text targetCountText; // Ссылка на UI текст
    private int targetCount = 0; // Счётчик разбитых мишеней

    public void IncrementTargetCount()
    {
        targetCount++; // Увеличиваем счётчик
        targetCountText.text = "Targets Destroyed: " + targetCount; // Обновляем текст
    }
}
