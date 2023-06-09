using UnityEngine;
using UnityEngine.Rendering;

public class Ball : MonoBehaviour
{

    public float speedBall;

    public float randomDirectionX;
    public float randomDirectionY;

    public Rigidbody2D oRigidybody2D;

    public AudioSource soundBall;

    // Start is called before the first frame update
    void Start()
    {
        MooveBall(5F);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MooveBall(float value)
    {
        oRigidybody2D.velocity = new Vector2(value, value);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        randomDirectionX = Random.Range(0, 2);
        randomDirectionY = Random.Range(0, 2);

        soundBall.Play();
        oRigidybody2D.velocity += new Vector2(randomDirectionX, randomDirectionY);
    }
}
