# Patrick's Yum Run
<img src="SIBoard_modal.png" alt="alt text" width="200px" height="200px">
    
**SI Board Game**
<br>
Author: **Andrew Rodriguez**
---
### Table of Contents
- [Description](#description)
- [How To Use](#how-to-use)
- [Video Walkthrough](#video-walkthrough)
- [User Stories](#user-stories)
- [Author Info](#author-info)
---
## Description
SI Board Game is a Unity WebGL game that allows Supplemental Instruction leaders to gamify their exam reviews remotely by logging user data and simulating peronalized boards for study. Using Unity as the frontend with PHP and MySQL in the backend users data is persistant. Users can create and login using HTTPS-based user authentication with hashed passwords. Database supports (CRUD) Create, read, update, and delete operations.
#### Technologies
- C#
- PHP
- Unity
- Google Cloud Platform
- MySQL
---
## User Stories
* [x] User can **Create a unique account with hashed passwords and an email** to recieve confirmation codes
* [x] User can **Login with their account** from the login page
* [x] User can **Update account password** by recieving a reset email
* [x] User can **Create and save** up to 3 personalized study boards
* [x] User can **reopen saved** study boards
* [x] User can **Edit** the study board by inserting questions, and images
* [x] User can **Play** their study board game
---
## Video Walkthrough
Here's a walkthrough of implemented user stories:

<img src='http://i.imgur.com/link/to/your/gif/file.gif' title='Video Walkthrough' width='' alt='Video Walkthrough' />

### GIF created with [LiceCap](http://www.cockos.com/licecap/).
---
## How to use
1) Visit [andrewthedev.com/si-board-game/](https://www.andrewthedev.com/si-board-game/)
2) Create an account or play right away without the ability to save your progress. After creating your account input the confirmation code sent to your email
3) Login to your account
4) Click play
5) Create a game or choose from your 3 previously saved games. Delete a game to make room for a different game
6) Click on the numbered squares to input your questions and answers (**DONT FORGET TO SAVE YOUR PROGRESS**)
7) When ready, start the game and add as many students as you need
8) Roll the virual die and have the students answer the question
9) Move their character accordinanly to the rolled number
---
## Challenges
- Initially I struggled with the backend developement because it was totally new to me and I had to do a lot of research on PHP and MySQL
- Additionally setting up the Google cloud MySQL database was daunting at first but it was fairly easy in the end
---
## Author Info
- Linkedin - [@andrew-m-rodriguez](https://www.linkedin.com/in/andrew-m-rodriguez)
- Website - [andrewthedev](https://www.andrewthedev.com/)
