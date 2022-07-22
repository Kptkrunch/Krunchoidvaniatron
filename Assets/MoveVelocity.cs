using UnityEngine;

public class MoveVelocity : MonoBehaviour {

	[SerializeField] private float moveSpeed;
	private Rigidbody2D _rigidbody2D;
	private Vector2 _velocityVector;

	void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	public void SetVelocity(Vector2 velocityVector) {
		this._velocityVector = velocityVector;
	}

	private void FixedUpdate() {
		_rigidbody2D.velocity = _velocityVector * moveSpeed;
	}
	
}

