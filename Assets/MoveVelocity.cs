using UnityEngine;

public class MoveVelocity : MonoBehaviour {

	[SerializeField] private float moveSpeed;
	private Rigidbody2D _rigidbody2D;
	private Animator _animator;
	private Vector3 velocityVector;
	
	void Awake() {
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
	}

	public void SetVelocity(Vector3 velocityVector) {
		this.velocityVector = this.velocityVector;
	}

	private void FixedUpdate() {
		_rigidbody2D.velocity = velocityVector * moveSpeed;
		_animator.SetBool("isWalking", true);
	}
}

