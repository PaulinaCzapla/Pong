using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    private void Awake() //inicialization, is calles only once in objects life
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float x = (Random.value < 0.5f ? -1.0f : 1.0f); // random left or right
        float y = (Random.value < 0.5f ? Random.Range(-1.0f, -0.3f) : Random.Range(0.3f, 1.0f)); // set an angle

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }


}
