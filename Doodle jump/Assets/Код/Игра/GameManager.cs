using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Префаб платформы для создания
    public GameObject PlatformPrefab;
    public int PlatformCount;

    // Ссылка на текст
    public TextMeshProUGUI TextScore;
    public float DistancePerScore = 1f;

    // Указываем случайный разброс платформ по высоте
    [Range(1f, 3f)]
    public float PlatformOffsetY = 1f;

    // Указываем половину ширины сцены по горизонтали
    public float PlatformBoundX;

    private int _gameScore;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < PlatformCount; i++)
        {
            spawnPosition.y += Random.Range(1f, PlatformOffsetY);
            spawnPosition.x = Random.Range(-PlatformBoundX, PlatformBoundX);

            Instantiate(PlatformPrefab, spawnPosition, Quaternion.identity);
        }

        // Устанавливаем текст в "Счёт: 0"
        UpdateTextScore();
    }

    public void UpdatePlayerPosition(Vector3 newPosition)
    {
        if (newPosition.y / DistancePerScore > _gameScore)
        {
            _gameScore = Mathf.FloorToInt(newPosition.y / DistancePerScore);
            
            // Обновляем счёт
            UpdateTextScore();
        }
    }

    private void UpdateTextScore()
    {
        TextScore.text = "Счёт: " + _gameScore;
    }
}
