using UnityEngine;

public class GameAssets : MonoBehaviour {

	private static GameAssets _ar;

	public static GameAssets ar {
		get {
			if (_ar == null) {
				_ar = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
			}
			return _ar;
		}
		
		
	}
}

