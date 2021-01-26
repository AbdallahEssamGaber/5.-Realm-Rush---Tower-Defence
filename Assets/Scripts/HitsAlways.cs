using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitsAlways : MonoBehaviour
{
	[SerializeField] TMP_Text test;
	[SerializeField] EnemyDamage damage;


	public void Update()
	{
		test.text = damage.hits.ToString();
	}

}
