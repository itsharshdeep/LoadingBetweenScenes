using UnityEngine;
using System.Collections;
using ItsHarshdeep.LoadingScene.Constants;

#if (!UNITY_5_2 ||  !UNITY_5_2_3)
using UnityEngine.SceneManagement;
#endif

namespace ItsHarshdeep.LoadingScene.Controller
{

/// <summary>
/// It will add loading scene when transaction between two scenes
/// </summary>
	public class SceneController
	{

		public static string scene = "";
		public static string previousScene = ""; 

		/// <summary>
		/// It will automatically load the "Loading Scene" in-between your requested scene
		/// </summary>
		/// <returns>The level.</returns>
		/// <param name="sceneName">Scene name.</param>

		public static void LoadLevel (string sceneName, float loadingSceneWaitTime = 0)
		{
			Constants.Constants.LOADING_SCENE_WAIT_TIME = loadingSceneWaitTime;
			#if (!UNITY_5_2 ||  !UNITY_5_2_3)
			previousScene = SceneManager.GetActiveScene ().name;
			#else
			previousScene = Application.loadedLevelName.ToString();
			#endif

			scene = sceneName;

			#if (!UNITY_5_2 ||  !UNITY_5_2_3)
			SceneManager.LoadSceneAsync (Constants.Constants.LOADING_SCENE_NAME);
			#else
			Application.LoadLevelAsync (Constants.Constants.LOADING_SCENE_NAME);
			#endif
		}

		public static void LoadPreviousScene (float loadSceneDelayTime = 0)
		{
			if (previousScene == null || previousScene.TrimEnd ().ToString () == "")
				Debug.LogError ("There is currently no any previous scene yet");
			else 
				LoadLevel (previousScene, loadSceneDelayTime);
		}
	}
}