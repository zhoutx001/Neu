using UnityEngine;

public class Weight : MonoBehaviour {

	public float distanceFromChainEnd = 0.6f;

	public GameObject ropeCutter;
	bool isFreefall = false;

	Rigidbody2D rb;
	float dirX;
	float dirY;
	float moveSpeed = 20f;

	public void ConnectRopeEnd (Rigidbody2D endRB)
	{
		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
		joint.autoConfigureConnectedAnchor = false;
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd);
	}

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
    {
		dirX = Input.acceleration.x * moveSpeed;
		dirY = Input.acceleration.y * moveSpeed;
		isFreefall = ropeCutter.GetComponent<RopeCutter>().isCut;
	}

    private void FixedUpdate()
    {
		if (!isFreefall)
		{
			rb.velocity = new Vector2(dirX, dirY);
		}
		else {
			rb.AddForce(new Vector2(x: 0, y: -2.0f), ForceMode2D.Impulse);

		}
		   
    }
}
