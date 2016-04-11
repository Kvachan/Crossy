using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public enum RotationAxes
	{
		mouseXandY = 0,
		mousX = 1,
		mouseY = 2
	}

	public RotationAxes axes = RotationAxes.mouseXandY;

	private float _rotationX = 0.0f;
	private float _rotationY = 0.0f;

	private float _minX = -45.0f;
	private float _maxX =  45.0f;


	private float _minY = -45.0f;
	private float _maxY =  45.0f;

	private float _rotationVelocity = 5.0f;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (axes == RotationAxes.mousX)
//		{
//			_rotationX -= Input.GetAxis("Mouse X") * _rotationVelocity;
//			_rotationX = Mathf.Clamp(_rotationX, _minX, _maxX);
//			transform.Rotate(_rotationX, 0, 0);
//		}
//		else if (axes == RotationAxes.mouseY)
//		{
//			_rotationY -= Input.GetAxis("Mouse Y") * _rotationVelocity;
//			_rotationY = Mathf.Clamp(_rotationY, _minY, _maxY);
//			transform.Rotate(0, _rotationY, 0);
//		}
//		else
//		{
			_rotationX -= Input.GetAxis("Mouse Y") * _rotationVelocity;
			_rotationX = Mathf.Clamp(_rotationX, _minX, _maxX);

			float delta = Input.GetAxis("Mouse X") * _rotationVelocity;
			_rotationY = transform.localEulerAngles.y + delta;

			transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
//		}
	}
}
