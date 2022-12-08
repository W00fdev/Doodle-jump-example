using UnityEngine;

public class PersistentData : MonoBehaviour
{
    public bool SoundOn = true;

    // Здесь может хранится любая информация:
    // Настройки громкости, очки игрока и пр.
    // ДЗ - сделать очки игрока сохраняющимися
    
    void Start()
    {
        // Просим не уничтожать себя при смене сцены.
        DontDestroyOnLoad(gameObject);
    }
}
