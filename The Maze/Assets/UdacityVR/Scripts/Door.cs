using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public GameObject leftDoor;
    public GameObject rightDoor;

    public AudioSource audioSource;
    public AudioSource noExitAudio;

    public bool locked = true;
    public bool opening = false;

    public Quaternion leftDoorStartRotation;
    public Quaternion leftDoorEndRotation;
    public Quaternion rightDoorStartRotation;
    public Quaternion rightDoorEndRotation;
    
    public float timer = 0f;
    public float rotationTime = 5f;


	void Start () {
        // Use 'leftDoor' to get the start rotation of the 'Left_Door' game object and assign it to 'leftDoorStartRotation'
        leftDoorStartRotation = leftDoor.transform.rotation;
        // Use 'leftDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Left_Door' game object and assign it to 'leftDoorEndRotation'
        leftDoorEndRotation = Quaternion.Euler(-90, 0, 180);
        // Use 'rightDoor' to get the start rotation of the 'Right_Door' game object and assign it to 'rightDoorStartRotation'
        rightDoorStartRotation = rightDoor.transform.rotation;
        // Use 'rightDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Right_Door' game object and assign it to 'rightDoorEndRotation'
        rightDoorEndRotation = Quaternion.Euler(-90, 0, -180);
    }


	void Update () {
		//Door opening if boolean true
        if (opening == true)
        {
            leftDoor.transform.rotation = Quaternion.Slerp(leftDoorStartRotation, leftDoorEndRotation, timer / rotationTime);
            rightDoor.transform.rotation = Quaternion.Slerp(rightDoorStartRotation, rightDoorEndRotation, timer / rotationTime);
            timer = timer + Time.deltaTime;
        }
	}


    public void OnDoorClicked()
    {
        // Called when the 'Left_Door' or 'Right_Door' game object is clicked
        // - Starts opening the door if it has been unlocked
        // - Plays an audio clip when the door starts opening

        // Prints to the console when the method is called
        Debug.Log("'Door.OnDoorClicked()' was called");

        if (locked == false)
        {
            opening = true;
            audioSource.Play();
        }
        else
        {
            noExitAudio.Play();
        }
    }

    public void Unlock () {
		// Called from Key.OnKeyClicked(), i.e. the Key.cs script, when the 'Key' game object is clicked
		// - Unlocks the door

		// Prints to the console when the method is called
		Debug.Log ("'Door.Unlock()' was called");

        locked = false;
	}
}
