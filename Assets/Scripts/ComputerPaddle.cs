using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if(ball.velocity.x < 0.0f) // ball going towards paddle
        {
            if(ball.position.y > this._rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
            else if(ball.position.y < this._rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if(this._rigidbody.position.y >0.0f)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
            else if (this._rigidbody.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
