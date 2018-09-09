using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public GameObject coinPoofPrefab;

    void Update () {
        //Coin animated to rotate 
        transform.Rotate(50 * Vector3.up * Time.deltaTime);
    }


	public void OnCoinClicked () {
		// Called when the 'Coin' game object is clicked
		Debug.Log ("'Coin.OnCoinClicked()' was called");
        Instantiate(coinPoofPrefab, this.transform.position, coinPoofPrefab.transform.rotation);
        Destroy(transform.root.gameObject, 0.5f);
    }
}
