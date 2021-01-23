using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeScript_Gori : MonoBehaviour
{
	private float time = 20;

	public GameObject GameFinishText_Gori;

	void Start()
	{
		GameFinishText_Gori.SetActive(false);
		//初期値60を表示
		//float型からint型へCastし、String型に変換して表示
		//GetComponent<Text>().text = ((int)time).ToString();
	}

	void Update()
	{
		//1秒に1ずつ減らしていく
		time -= Time.deltaTime;

		if (time < 0)
		{
			StartCoroutine("GameFinish");
		}

		//マイナスは表示しない
		if (time < 0) time = 0;
		//GetComponent<Text>().text = ((int)time).ToString();
	}

	IEnumerator GameFinish()
	{
		GameFinishText_Gori.SetActive(true);

		yield return new WaitForSeconds(2.0f);
		if (Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene("End");
		}
	}
}