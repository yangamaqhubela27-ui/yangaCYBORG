# YangaCYBORG Cybersecurity Awareness Chatbot

## Project Overview

YangaCYBORG is a C# cybersecurity awareness chatbot created to teach users about basic online safety. The chatbot provides a friendly and interactive experience where users can enter their name and receive information about different cybersecurity topics.

The project was created as part of my Programming POE. It demonstrates user input, string handling, conditional statements, input validation, methods and classes, audio integration, ASCII art and console formatting.

## Features

The chatbot includes the following features:

- Plays a recorded voice greeting when the application starts.
- Displays a cybersecurity-themed ASCII logo.
- Asks the user to enter their name.
- Uses the user's name to personalise the interaction.
- Prevents the user from continuing without entering a name.
- Provides cybersecurity awareness information.
- Responds to the user's selected questions and topics.
- Handles unsupported or invalid input.
- Uses formatting to make the chatbot easier to read.
- Displays a friendly closing message using the user's name.

## Cybersecurity Topics

The chatbot provides basic information about cybersecurity topics such as:

- Phishing
- Password safety
- Cyberbullying
- Online privacy

These topics are included to help users understand common online risks and how they can protect themselves.

## Voice Greeting

A recorded voice greeting is played when the chatbot starts. The audio is stored as a WAV file in the project.

The WAV file can be found in:

`recording/YangaCY.wav`

The voice greeting makes the chatbot more welcoming and interactive.

## ASCII Art and Console Interface

The chatbot displays ASCII art when the application starts. This is used as a visual logo for the Cybersecurity Awareness Bot.

The console interface also uses formatting, spacing and structured messages to make the chatbot easier for the user to follow.

## User Interaction and Input Validation

The chatbot asks the user for their name and uses it to personalise messages.

Input validation is included to prevent the user from continuing without providing the required information. The chatbot also handles inputs that it does not recognise by providing an appropriate response instead of ending unexpectedly.

## Code Structure

The project is divided into different C# files to keep the code organised and readable.

- `Program.cs` – controls the main flow of the application.
- `ChatBot.cs` – contains the chatbot interaction and response functionality.
- `Logo.cs` – contains the ASCII logo functionality.
- `recording/YangaCY.wav` – contains the recorded voice greeting.

Using separate files and methods helps keep the program organised instead of placing all functionality inside one file.

## Technologies Used

- C#
- .NET
- Visual Studio
- Git
- GitHub
- GitHub Actions

## GitHub Version Control

GitHub is used for version control throughout the development of the project. Meaningful commits are used to record changes and improvements made to the chatbot.

This makes it possible to track the development of the project and maintain a history of changes.

## Continuous Integration (CI)

GitHub Actions is used for Continuous Integration.

The CI workflow automatically restores and builds the project when changes are pushed to the `master` branch. This helps check that the project can build successfully and identifies build errors.

The workflow file is stored in:

`.github/workflows/dotnet-desktop.yml`

### Successful CI Workflow

![Successful CI Workflow](Screenshot%202026-09-08%20185936.png)

The screenshot above shows a successful GitHub Actions workflow run with a green check mark.

## How to Run the Project

1. Clone or download the GitHub repository.
2. Open `yangaCYBORG.sln` in Visual Studio.
3. Make sure the WAV voice greeting file is available in the `recording` folder.
4. Build the project.
5. Run the application.
6. Enter your name when requested.
7. Interact with the chatbot and select or ask about the available cybersecurity topics.

## YouTube Presentation

The project presentation demonstrates the chatbot and explains the code structure, logic, voice integration and formatting techniques used.

**YouTube Presentation Link:**https://youtu.be/Z-JSp0F_TOE
## Author

Yanga Maqhubela

Programming POE – 2026
