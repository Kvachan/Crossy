using UnityEngine;
using System.Collections;

public class TranslateAction : MonoBehaviour {

    public float _translateVelocity;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        float deltaX = Input.GetAxis("Horizontal") * _translateVelocity;
        float deltaZ = Input.GetAxis("Vertical") * _translateVelocity;
        transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime); 
	}
}
