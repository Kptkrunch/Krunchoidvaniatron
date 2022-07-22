using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour {
	private Vector2 _moveInput;
	private void Update() {
	
		
	}

	private void OnMove(InputValue value) {
		_moveInput = value.Get<Vector2>();
		Debug.Log(_moveInput);
	}
}

