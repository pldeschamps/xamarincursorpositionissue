This project demonstrates the issue described there: https://github.com/xamarin/Xamarin.Forms/issues/8554

The output differs whenever the user adds characters in the Entry in the main Page whenever he starts the Android or the UWP project.

By adding two characters after starting the Android project, the output is:
[0:] cursor position: 0
[0:] cursor position: 1

By adding two characters after starting the UWP project, the output is:
cursor position: 1
cursor positio
