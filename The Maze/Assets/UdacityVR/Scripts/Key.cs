using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject 
    public GameObject keyPoofPrefab;
    // Declare a Door named 'door'
    public Door door;


    void Update () {
        // Rotating Key Animation
        transform.Rotate(50 * Vector3.forward * Time.deltaTime);
    }


	public void OnKeyClicked () {
		/// - Unlocks the door (handled by the Door class)

		// Prints to the console when the method is called
		Debug.Log ("'Key.OnKeyClicked()' was called");
        Debug.Log("'Coin.OnCoinClicked()' was called");
        Instantiate(keyPoofPrefab, this.transform.position, keyPoofPrefab.transform.rotation);
        Destroy(transform.root.gameObject, 0.5f);

        door.Unlock();
    }
}
