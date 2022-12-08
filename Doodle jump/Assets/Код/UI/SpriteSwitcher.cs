using UnityEngine;
using UnityEngine.UI;

// Скрипт для смены спрайтов на объекте, необходим компонент SpriteRenderer 
[RequireComponent(typeof(Image))]
public class SpriteSwitcher : MonoBehaviour
{
    // Сменяющиеся спрайты
    public Sprite SpriteVersionOn;
    public Sprite SpriteVersionOff;

    // На какой спрайт меняем (true = ON, false = OFF)
    public bool Switcher = true;

    // Компонент картинки (не спрайта).
    private Image _imageUI;

    // Start is called before the first frame update
    void Start()
    {
        // Получаем компонент рендера спрайта
        _imageUI = GetComponent<Image>();

        // Вызываем собственную функцию, которая обновляет спрайт в соответствии с флагом Switcher
        UpdateSprite();
    }

    public void SwitchSprite()
    {
        // Переключаем флаг на противоположный
        Switcher = !Switcher;

        UpdateSprite();
    }

    void UpdateSprite()
    {
        // При включенном переключателе
        if (Switcher == true)
        {
            // Устанавливаем в рендере спрайта версию "Спрайт Включенный"
            _imageUI.sprite = SpriteVersionOn;
        }
        // При выключенном переключателе
        else
        {
            _imageUI.sprite = SpriteVersionOff;
        }
    }    
}
