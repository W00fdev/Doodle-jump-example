using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Укажи объект с данными:")]
    public PersistentData PersistentDataObject;

    [Header("Канвас главного меню:")]
    public GameObject CanvasMainMenu;

    [Header("Канвас опций:")]
    public GameObject CanvasOptions;

    [Header("Название сцены игры")]
    public string PlaySceneName;

    private bool _isSoundOn = true;

    public void StartGame()
    {
        // using UnityEngine.SceneManagement; 
        // указать для работы в начале файла

        // Вызываем функцию глобальный SceneManager(менеджер сцен) "Загрузи сцену (строка-имя сцены)"
        SceneManager.LoadScene(PlaySceneName);
    }

    public void QuitGame()
    {
        // Глобальный класс Application(приложение) Выйди из игры.
        Application.Quit();
    }

    public void ShowMenu()
    {
        // Включаем канвас меню и выключаем опций

        CanvasMainMenu.SetActive(true);
        CanvasOptions.SetActive(false);
    }

    public void ShowOptions()
    {
        // Включаем канвас опций и выключаем меню

        CanvasMainMenu.SetActive(false);
        CanvasOptions.SetActive(true);
    }

    public void SwitchSound()
    {
        // Меняем bool значение на противоположное (false == !true)
        _isSoundOn = !_isSoundOn;

        // Указываем в объекте данных новое значение включенного звука
        PersistentDataObject.SoundOn = _isSoundOn;
    }
}
