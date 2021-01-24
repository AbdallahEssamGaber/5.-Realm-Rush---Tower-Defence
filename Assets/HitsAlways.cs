using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitsAlways : MonoBehaviour
{


	private void Update()
	{
		this.GetComponent<TextMeshPro>().text = EnemyDamage.hits.ToString();
	}

}
