Hangman v1.00
=============

Hangman is a simple word guessing game that allows a player the chance to guess letters of
a hidden word (or the word itself).  This game gives a player 6 chances to guess the word
before being 'hung'.  This game of Hangman contains a list of 500+ words that can be used
or words entered during game time (note, if the word file cannot be found, words must be 
entered by the players).  To be fun, most of the words should be at least 4 characters long 
and are limited to 20 characters.

The game includes several setable options including defining your own list of words,
selecting game sounds, to use sound or not and to display some of the prompts or not.

Hangman was originally written using Speedsoft's Sibyl in OS/2.  Rewrote it using VS 2019
in C# for Windows.
The code is available by request (just e-mail me :)).  If you run into any problems, errors,
have gripes or just plain don't like something, let me know also (I get/got enough of the stealth
complaints at work :)).

Note: A list of German language words has been provided by Hermann Mahr
      (Hermann.Mahr@t-online.de) and is included for those that wish to use it.  The
      file is named "HM_woerter.TXT".

Fixes/additions:
----------------
Version 1.00 - Converted from Object Pascal to C#, OS/2 to Windows.

To play:
--------
After starting the program, press the 'start' button.  A dialog will be displayed which you
can then enter a word for someone to guess or let the game pick a word from the word
list (if available).  After a word is selected, the 'guess' button becomes enabled.  Press
'guess' to guess a letter or guess the word.  Keep pressing 'guess' until you guess the 
word or you are 'hung'.  Once this happens, the 'guess' button is disabled and you can
then press the 'new' button to select another word.  Number of words guessed/missed is
tracked on the main window.  You can keep guessing at words until you get tired, then
press the 'exit' button.

Options:
--------
Pressing the 'options' button allows the setting of several options.  You can select your 
own word list file (any text file with a list of words in it will do), to have sound or not,
and if prompting is turned on for new word selection and game exiting.  In addition, you
can select the sounds used for some of the game events.  Two sound files are included with
the game, BEEP.WAV and SWINGING.WAV.  My favorite for the Finished word sound is
APPLAUSE.WAV included with warp (I didn't include this one for obvious reasons :)).  Two
lists of words are currently provided, one in english ("HM_Words.TXT") and another in
german ("HM_woerter.TXT").

Contact:
--------
You can e-mail me (Michael Slack) at 'mike.g.slack@gmail.com' with any questions, complaints,
etc.  Use the program at your own risk.