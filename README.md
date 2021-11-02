# Control Expert - DFB Password

## Description
This program is used to find passwords of Derived Function Block on "EcoStruxure Control Expert" or "Unity" software.

## How to use
1/ First, take a DFB in Control Expert or Unity with "Crypted password":  

![DFB_Crypted_1](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_2.PNG?raw=true) 
![DFB_Crypted_2](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_3.PNG?raw=true) 

2/ Open a ".stu" file program with 7Zip:  

![DFB_Crypted_3](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_4.PNG?raw=true)

3/ Extract "PathBase.db":  

![DFB_Crypted_4](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_5.PNG?raw=true)

4/ Open "PathBase.db" with hexadecimal software like HxD:  

![DFB_Crypted_5](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_6.PNG?raw=true)

5/ Search for hex strings in a file the DFB (in my case "Axis_3pos"):

![DFB_Crypted_6](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_7.PNG?raw=true)
![DFB_Crypted_7](https://github.com/Bernardo59/ControlExpertDFBPassword/blob/master/assets/DFB_8.PNG?raw=true)


You need "Python 3.7" to use this program.  

>py -3.7 main.py (on windows)
>python3.7 main.py (on linux)

## Screenshot
![DFB Password](https://raw.githubusercontent.com/Bernardo59/ControlExpertDFBPassword_Window/master/assets/EcoStruxureDFBPassword.PNG)
