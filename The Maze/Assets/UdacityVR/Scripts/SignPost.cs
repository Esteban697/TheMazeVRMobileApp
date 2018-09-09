using UnityEngine;
using UnityEngine.SceneManagement;


public class SignPost : MonoBehaviour {

    private Scene scene;

    public void ResetScene () {
		/// Called when the 'SignPost' game object is clicked
		/// Reloads the scene

		// Prints to the console when the method is called
		Debug.Log ("'SignPost.ResetScene()' was called");
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}
}