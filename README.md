# Music Theory App

## Description

This application is a quiz app based around one's knowledge of musical scales. There are four different sections to the app: scales, quiz, quiz results, and temperature converting. The 'scales' section tells the user the difference between major and minor scales and provides some examples. The quiz is the actual quiz. Note, to get an answer correct the input must be 'major' or 'minor'. Quiz results tell the percentage correct. If multiple quizes are taken then those answers are added onto the previous ones. The final portion of the app is the temperature conversion tool. It is common for someone to be using their music theory app and then feel that they need to convert the temperature right then and there... this app can do that. 

## Features 

1. Master Loop

The entire application is centered around a master loop that serves as the menu of the app. Entering 1,2,3, or 4 will send the user to different portions of the app. At the end of each of the four areas of the app the user will be asked if they want to go back to the main menu or not. If the answer is no then the app closes. 

2. Created a list and populated it with values

A list is created of type 'Questions' of hard coded values found in the Questions class. This list is then used as the quiz section of the app.  

3. Built a conversion tool

This feature takes in user input whether they would like to convert from Celsius to Fahrenheit or vice a versa, the user inputs the first temperature, and the tool gives the user the converted value. 

## Test Answers
1. major
2. minor
3. major
4. minor
5. major