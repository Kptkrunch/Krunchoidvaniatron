using UnityEngine;

public class AnimationController : MonoBehaviour {
	private Animator _animator;
	private Rigidbody2D _rigidbody2D;
	void Awake() {
		_animator = GetComponent<Animator>();
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		FlipSprite();
		RunAnimation();
	}

	void FlipSprite() {
		bool playerHasHorizontalSpeed = Mathf.Abs(_rigidbody2D.velocity.x) > Mathf.Epsilon;

		if(playerHasHorizontalSpeed) {
			transform.localScale = new Vector2(Mathf.Sign(_rigidbody2D.velocity.x), 1.0f);
		}
	}

	void RunAnimation() {
		if(Mathf.Abs(_rigidbody2D.velocity.x) > Mathf.Epsilon) {
			_animator.SetBool("isRunning", true);
		} else {
			_animator.SetBool("isRunning", false);
		}
	}
}

