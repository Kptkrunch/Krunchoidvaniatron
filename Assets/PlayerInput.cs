using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour {
	private Vector2 _moveInput;
	private void Update() {
		Run();
		
	}

	private void OnMove(InputValue value) {
		_moveInput = value.Get<Vector2>();
		Debug.Log(_moveInput);
	}

	private void Run() {
		Vector2 playerVelocity = new Vector2(_moveInput.x, 0);
		GetComponent<MoveVelocity>().SetVelocity(playerVelocity);
	}
	
}

