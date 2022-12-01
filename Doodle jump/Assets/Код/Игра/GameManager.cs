using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Префаб платформы для создания
    public GameObject PlatformPrefab;
    public int PlatformCount;

    // Указываем случайный разброс платформ по высоте
    [Range(1f, 3f)]
    public float PlatformOffsetY = 1f;

    // Указываем половину ширины сцены по горизонтали
    public float PlatformBoundX;

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
    }

}
