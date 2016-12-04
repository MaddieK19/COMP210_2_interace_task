#COMP210 – Assignment 2 Proposal

###Assets Used from Unity Asset store:
* [Falcon model and animations](https://www.assetstore.unity3d.com/en/#!/content/26962)
* [Grass texture](https://www.assetstore.unity3d.com/en/#!/content/29037)
* [Smart phone model and animations](https://www.assetstore.unity3d.com/en/#!/content/58471)
* [Skybox](https://www.assetstore.unity3d.com/en/#!/content/21737)
* [SteamVR plugin](https://www.assetstore.unity3d.com/en/#!/content/32647)

My COMP230 component is a companion Falcon AI. For COMP210 I’d like to make a VR interface to interact with the AI.  
 
The main way to interact with the falcon will be using a smart phone to command it in game. This will use the Vive controller track pad and grip button to operate. The user can use the track pad to swipe through different screens on the phone and press it to select one.  The controller can vibrate when the player needs to look at it.  
 
Most players will have or know how to operate a smart phone it so should be intuitive for the player to use. The Vive controller has a track pad which can be swiped in the same way as a smart phone.   

The other Vive controller will be used to track the players arm position when they raise their arm high enough the falcon will land on it in game and an Arduino will be used to pinch the players arm to simulate the falcon landing on their arm.   
![Vive Controller](https://www.vive.com/uploadedimages/common/ditahowto/site_us/vive/GUID-2D5454B7-1225-449C-B5E5-50A5EA4184D6-web.png)  

##Market Research:
###Bird related VR games:
How We Soar and Eagle Flight are two existing VR games that have not been released yet. They both focus on birds flying. However they both involve the player playing as a bird and flying around. These games appear to only use the controller to interact with the player.
Another bird based VR system is Birdly, this requires the player to flap there are to mimic flying and provides other feedback such as smell and wind from a fan.  
###Companion AIs in VR games
Robinson: The Journey is a VR game where the players has a robot companion AI. There’s not much footage of this game as it hasn’t been released but it looks like the player can bat the robot away and may feel some vibration from the controller as feedback

![Robinson](http://cdn.uploadvr.com/wp-content/uploads/2016/08/Robinson-5.jpg)  
Above shows the companion AI in Robinson.  

PlayStation Playroom VR again has a robot AI that can be moved around by the player touching it with a controller.   

###VR games and feedback
PlayStation VR Worlds uses vibration to mimic touching something.  Also in the menu hub the player can’t move there hand through objects the objects just move away and may cause controller vibration.   

Vibration seems to be a common way to provide some sort of feedback for touching objects in VR games. I intend to use vibration to draw the players attention to the phone in game for example when the falcon has low health the phone will vibrate to alert the player.

[Unlimited Hand](http://unlimitedhand.com/) is another method to provide feedback in VR games. It's an arm band that stimulates the players muscles to simulate tactile feedback. They even have an example of using it to have a bird land on the players hand. 
![unlimited hand](http://unlimitedhand.com/images/about_01.png)  
However this is very expensive I will being using an Arduino instead to pinch the players arm so it feels like a falcons talon landing on the players arm.
