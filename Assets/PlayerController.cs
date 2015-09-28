using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;

    public float thrustPower;
    public float frictionFactor;

    public bool grounded;
    public bool movingRight;


    public void MoveLeft()
    {
        Debug.Log("LEFT " + thrustPower);

        Vector2 thrustV = new Vector2(-thrustPower, 0);

        this.rb.AddForce(thrustV);
    }

    public void MoveRight()
    {
        Debug.Log("RIGHT " + thrustPower);
        Vector2 thrustV = new Vector2(thrustPower, 0);

        this.rb.AddForce(thrustV);
    }

    public void MoveUp()
    {
        Debug.Log("UP " + thrustPower);
        Vector2 thrustV = new Vector2(0, thrustPower);

        this.rb.AddForce(thrustV);
    }

    public void MoveDown()
    {
        Debug.Log("DOWN " + thrustPower);
        Vector2 thrustV = new Vector2(0, -thrustPower);

        this.rb.AddForce(thrustV);
    }

    /// <summary>
    /// applies a simulated friction to the player (no PhysicsMaterial needed)
    /// </summary>
    void SimulateFriction()
    {
        // simulate Friction on x axis
        Vector3 easeVel = rb.velocity;
        easeVel.x *= this.frictionFactor;
        easeVel.y = rb.velocity.y;
        easeVel.z = 0.0f;
        // fake friction
        if (grounded)
        {
            rb.velocity = easeVel;
        }
    }



	// Use this for initialization
	void Start () {
        this.rb = gameObject.GetComponentInChildren<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (this.rb.velocity.x > 0)
        {
            this.movingRight = true;
        }
    }
    /// <summary>
    /// PHYSICS
    /// </summary>
    void FixedUpdate()
    {
        SimulateFriction();
    }
}
