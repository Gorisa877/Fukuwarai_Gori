using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem_Gori : MonoBehaviour
{

	//　スタートボタンを押したら実行する-->Main（ゲーム画面）に遷移
	public void StartGame()
	{
		SceneManager.LoadScene("Main");
	}

	//　Exitボタンを押したら実行する-->ゲーム画面を閉じる
	public void EndGame()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
	}

	//　リトライボタンを押したら実行する-->最初のタイトル画面に戻る
	public void ReGame()
	{
		SceneManager.LoadScene("Title");
	}

	//　AddPictureボタンを押したら実行する-->トリミングの画面に移動
	public void AddPicture()
	{
		SceneManager.LoadScene("AddPicture");
	}

	//　AddPictureボタンを押したら実行する-->トリミングの画面に移動
	public void Triming()
	{
		SceneManager.LoadScene("Triming");
	}
}

