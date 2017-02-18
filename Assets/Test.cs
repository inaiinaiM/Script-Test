using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Start () {
		
		int[] array = { 11, 22, 33, 44, 55 };

		Debug.Log (array [0]);
		Debug.Log (array [1]);
		Debug.Log (array [2]);
		Debug.Log (array [3]);
		Debug.Log (array [4]);

		for (int i = array.Length - 1; 0 <= i; i-- ) {
			Debug.Log (array[i]);
			}

	}

	void Update () {

	}
}