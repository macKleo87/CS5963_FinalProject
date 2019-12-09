# CS5963_FinalProject

Important information for running our project
- We used Unity 2018.2.21f1 and does not work on newer version (like the ones in the library). We haven't been able to pull up our unity project in the library because of this and we were told no one could help us install other versions of unity (admin login required). Please keep this in mind when pulling up our project.
- Our most recent push was from a mac, so the project might need re-targetting if pulled up on windows.
- We have developed for the Oculus and do not support Valve Index, so if you are running the executable on the Index systems, please use keyboard to instructions below to navigate the project.

Important information for interacting with our project
- Use "B" on keyboard or "A" on xbox controller to Restart the scene
- Use "W","A","S", and "D" on keyboard or xbox controller joystick to navigate the player controller
- Move the player up to the podium to start your speech experience!
- Use "esc" on keyboard to quit the running project
- The experience is roughly 5 minutes long.

Deliverable check-list (pulled from formal project proposal)
- We will create a VR simulation of a glossophobic experience
  - We have full support of this item. This is our most abstract check-list item at the beginning of our proposal. We have created a speech experience that includes glossophopic-type sensation and it is in VR.
- We will create an educational experience rather than a therapeutic experience
  - We have full support of this item. While we do not explicitly "teach" the user about glossophobia, we show them through sound and visuals combined with a first-person perspective.
- We will include an unamused audience who is unpleasant to present in front of.
  - We have full support of this item. We have an audience who is very noisy and distruptive. The audience includes noisy children, coughing, fidgiting, un-silenced cell phones, awkward silences, and unenthusiastic applause. All of these events occur at least once during the speech and sound effects. The audience also visually fidgets just slightly to give them the appearance of a live audience. 
- We will include blurry vision and tunnel vision
  - We have partial support of this item. We have a tunnel vision effect that occurs twice during the speech but we do not have a blurry vision effect. [MORE NEEDED]
- We will have ringing in the ears and heartbeat sound effects
  - We have partial support of this item. We have the heart beat sound effect that occurs during the tunnel vision effect. We do not have ringing in the ears. We instead added microphone feedback twice during the speech as a annoying and tense sound for the speaker. 
- We will have a pre recorded track of a speech that the user can listen to while on stage to simulate them speaking. 
  - We have full support of this item. We recorded the speech with the help of a friend volunteering their voice. We chose a somewhat childish speech so that it would be non-distracting and easy to comprehend. 
- We will have occasions where it sounds like the user is running out of breath and has to stop to catch their breath.
  - We have full suport of this item. There are moments, especially during the tunnel vision where the speaker breathes slowly and takes pauses to collect themselves.
- We will have whispers from the audience occur during these dead-silent moments.
  - We have full suport of this item. During the whole speech, there is ambient audience sounds which includes some whispering, and we added some louder whispering during particularly silent points in the speech when the speaker might feel uncomfortable. 
- We will program events for people in the audience to appear more disinterested.
  - We have partial support of this item. This item was fulfilled all through sound effects. We did not have the time capacity to animate the audience further than slight fidgeting.
- We will implement the tunnel vision effect by drawing on a GUITexture display.
  - We have full support of this item but we did it slightly differently. We used a second camera as a child to the player controller and attached a canvas image to the camera that we gradually change in size to create the tunnel vision effect. 
- We will have a large audience.
  - We have full support of this item but slightly differently. We chose to do a medium audience with the seats partially full. We thought this would be better appropriate with the speech topic we chose, so we went with a slightly smaller auditorium. 
- We will have the user see their clammy hands
  - We do not have support for this item. We decided early on that including hands in this experience was out of scope for our team. We felt that seeing the speaker's hands was not vital to our experience being effective.
