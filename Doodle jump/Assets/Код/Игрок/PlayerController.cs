using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float JumpForce;

    // Компонент физического движка на объекте
    private Rigidbody2D _rb2d;
    private float _moveX;

    // Start is called before the first frame update
    void Start()
    {
        // Получение физического движка для объекта.
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Получаем ввод с клавиатуры (-1..0..1) * скорость передвижения
        _moveX = Input.GetAxis("Horizontal") * MoveSpeed;
    }

    void FixedUpdate()
    {
        // Изменяем горизонтальную скорость в физическом движении через ввод _moveX
        _rb2d.velocity = new Vector2(_moveX, _rb2d.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Мгновенно единоразово увеличиваем вертикальную скорость в физическом движении переменную JumpForce
        // Со временем, гравитация перебарывает прыжок 

        if (_rb2d.velocity.y <= 0f)
        {
            // Мы отталкиваемся от платформы только когда падаем
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, JumpForce);
        }
    }
}
