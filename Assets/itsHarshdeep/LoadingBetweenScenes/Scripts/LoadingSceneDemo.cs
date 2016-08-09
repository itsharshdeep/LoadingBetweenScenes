using UnityEngine;
using System.Collections;

//Add following header files
using ItsHarshdeep.LoadingScene.Constants;
using ItsHarshdeep.LoadingScene.Controller;

public class LoadingSceneDemo : MonoBehaviour
{
	public bool requiredCustomDelay = true;

	void Start ()
	{
	}

	// Calling from outside on the 'Load Scene 1' & 'Load Scene 2' button
	public void LoadScene (string sceneName)
	{
		if (requiredCustomDelay)
			SceneController.LoadLevel (sceneName, 1.5f);
		else
			SceneController.LoadLevel (sceneName);
			
		print ("Previous Scene name was : " + SceneController.previousScene);
	} 

	// This will automatically load the previously loaded scene
	public void LoadPreviousScene ()
	{
		SceneController.LoadPreviousScene ();

		/*You may pass te Delay parameter for the previous scene's Loading scene 
		 *Example : SceneController.LoadPreviousScene(1.25f);
		 */

	}

}
