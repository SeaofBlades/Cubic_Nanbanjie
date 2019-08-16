WebGL Build Setup:

1: Go to "File" and then "Build Settings" within Unity

2:In the window that pops up, in the "Platform" section select "WebGL"

3:(Optional) If you do not have the WebGL Platform installed, click the "Open Download Page" Button and follow the instructions

4:With WebGL selected, press the "Switch Platform" button in the bottom right of the window

5: You are now ready to make WebGL builds.

------------------------------------------------------------------------------------------------------------------------------------------

How to use the Custom Music script

1:Select the Gameobject (Scene) that you wish to attach custom music to

2: Add the "CustomMusic" script to the object

3: Add an Audiosource to the selected Gameobject

4: if you wish to play a new song during this scene, then add audio to the audio source. Otherwise, simply leave it empty and it will instead mute the main background music

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

How to Create and Add Questions to the Quiz
Note: Everything discussed in this section will be inside of the "S7b UI_Quiz" Gameobject

1: RECOMMENDATION: I would recommend using one of the template questions that are inside of the "Testing Questions" Gameobject. However should you feel comfortable, feel free to create them from scratch.

2: Make sure that the question parent object has the "Button_Tracker" Script attached to it.

3: take the answer gameobjects inside of the question parent and add them to the "Answers" list. it is part of the "Button_Tracker" Script and you should see it in the inspector

4: Make sure that "Answer_Bool" Scripts are attached to each one of the Answer buttons inside of the question.

5: in the inspector, add the other answer buttons (IE: Siblings) to each of the answer buttons "Answer_Bool" Script in the inspector

6: Mark the correct answer by checking the "Is_correct" checkbox on the correct answer

7: On each answer button, in the inspector, add a function to the "On_Click" function of the button.

8: Add the currently selected button to its own "On_click" function.

9: From the function list, select "Answer_Bool.Question_answer"

10: repeat steps 4-9 with each answer button until all of them are correctly filled out.

11: On the "S7b_UI_Quiz" Gameobject, add your newly created question game object to the "question_list" in the inspector as part of its "NEW_Multipul_choice_quiz" script.

12: test to make sure that your newly added question functions as intended.