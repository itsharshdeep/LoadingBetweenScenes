Loading Between Scenes
Intro: 

This package lets incorporate the loading scene in between your two scenes. 
For Example: You have to go from Menu to Level1. This package will let you load the loading screen automatically in between your two scenes.

This can be used anywhere like Menu -> LevelX, LevelX -> Upgrade Store etc etc .

There is also facility whether you don't want to show the loading screen Like from Splash Scene to Landing/Home scene you can easily do so.

***One extra Feature*** 

It will also let you know the previous loaded scene name. 


Assets Included

Demo Scenes:
Scene1
Scene2
LoadingScene

Scripts :
Constants
LoadingSceneController
LoadingSceneDemo
LoadRequestedScene
SceneController

Instructions for Use
Where ever you want to load the LoadingScene you need to call a method named:
SceneController.LoadLevel (sceneName);

To Use this you need to add header file : 
using ItsHarshdeep.LoadingScene.Controller;




If you don’t want to use the loading  scene then just go for the Inbuilt Unity method like :

SceneManager.LoadSceneAsync (Constants.LOADING_SCENE_NAME);

//Or for Unity Below 5.3.1
			
Application.LoadLevelAsync(Constants.Constants.LOADING_SCENE_NAME);

One More thing :
There is also overload methods present for LoadingScene method:

SceneController.LoadLevel (sceneName,loadingSceneWaitTime);

This parameter will help you to put the delay on the loading scene, which may be useful when you need to wait user on your loading scene . Some time Developer made their loading screen very beautiful or with cool animations. So in that case you may need that 

Same for the Previous scene:

SceneController.LoadPreviousScene(1.25f);

You can remain this parameters empty. With empty field it will automatically assumes that you don’t want to put the delay in that 

*** There is a Checkbox/bool tick marked/True in Scene2 on GameObject named ‘Script’ component ‘LoadingSceneDemo.cs’ by which it will put some delay of 1.5 seconds from Scene 2 -> Scene 1. But in Scene1 there is no checkbox marked. So no delay from Scene1 -> Scene2 ****

*** If you want to change the LoadingScene Name. You need to update that in Constants.cs Class***