using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour {
	public class Magic{
		private int Maxmp = 53;
		public void Attack (int usemp)
		{
			int nowmp = Maxmp;
			for (int i = 0; i<= 12; i++) {
				nowmp -= usemp;
			
				if (nowmp >=5) {
					Debug.Log ("魔法攻撃をした。残りMPは" + (nowmp-usemp) + "。");

				} else {
					Debug.Log ("MPが足りないため魔法が使えない。");
				}
			
		

			}
		}

	}
	// Use this for initialization
	void Start () {
		int[] array = { 500, 4, 909, 298, 42 };
		for(int i = 0; i < array.Length; i++ ){
			Debug.Log(array[i]);
		}
		for(int i = array.Length - 1; i >= 0; i-- ){
			Debug.Log(array[i]);
		}
		Magic magic = new Magic();
		magic.Attack (5);







}
	// Update is called once per frame
	void Update () {
		
	}
}
