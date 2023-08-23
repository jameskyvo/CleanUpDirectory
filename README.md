# CleanUpDirectory
A simple file cleaning program designed for use with the task scheduler.

# Installation
Install the latest release and place it anywhere on your computer. In task scheduler, create a new task and make the action "Start a program". In Program/script, place the link to the executable file. Add the three required arguments inside of "Add arguments (optional)". This is mandatory.

## Adding Arguments
**ARGUMENTS ARE MANDATORY FOR PROPER PROGRAM FUNCTION!**
There must be 3 arguments for the program to work. If there is an incorrect number of argunments, the program will abort.

There are three mandatory arguments you must provide in the task scheduler: The folder that you would like to have cleaned, the number of days before the file is intended for deletion, and a true/false value for whether or not you would like this program to act recursively.


Here's an example:

**C:\Users\Personal\Downloads 7 true**

These arguments would clean files that have been unmodified for 7 days, as well as any subdirectories inside the downloads folder.

### This program permanently deletes files.
Please test this program before use on critical files. The developer is not responsible for any lost work that may occur from this program.

## MIT License
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the conditions of the MIT License.
