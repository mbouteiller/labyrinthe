using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	public string SceneLoaded = null;

	public void Load()
	{
			SceneManager.LoadScene(SceneLoaded);
	}
}