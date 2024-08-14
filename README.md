# TaskManager

# Overview
Task Manager is a simple console application built in C# that allows users to manage their daily tasks effectively. It’s a great starting point for learning basic programming concepts in C# such as object-oriented programming, list manipulation, and user interaction through a console interface.


# Features
- Add Task: Allows users to add a new task with a description.
- View Tasks: Displays all tasks, separated into pending and completed.
- Mark Task as Completed: Enables users to mark a task as completed.
- Remove Task: Allows users to remove a task from the list.


# Prerequisites
- .NET SDK installed on your machine.
- Basic knowledge of C# and Visual Studio or Visual Studio Code.

# Installation
1- Clone the repository:
git clone https://github.com/hctpgn/TaskManager.git

2- Navigate to the project directory:
cd TaskManager

3- Open the project in Visual Studio:
Open the TaskManager.sln file.
Alternatively, you can use Visual Studio Code by opening the folder and ensuring you have the C# extension installed.

# Running the Application

1- Build the project in Visual Studio or using the dotnet build command.

2- Run the application:
Press F5 in Visual Studio.
Or, use the dotnet run command in the terminal.

3- Interact with the application through the console interface. You’ll see a menu with options to add, view, complete, or remove tasks.

# Example Usage
Task Manager - Choose an option:
1. Add Task
2. View Tasks
3. Mark Task as Completed
4. Remove Task
0. Exit

Option: 1
Description of the Task: Finish C# project

Task 'Finish C# project' added successfully!

# Project Structure
Program.cs: The entry point of the application where the main logic and user interaction are handled.

Task.cs: Defines the Task class, representing individual tasks with properties like Id, Description, and IsCompleted.

TaskManager.cs: Contains the core functionality for managing the list of tasks, such as adding, viewing, completing, and removing tasks.

# Future Improvements
Persistent Storage: Saving tasks to a file or database so that they persist between application runs.
Task Priority: Adding a priority level to tasks to help users prioritize their work.
Due Dates: Implementing due dates for tasks and sending reminders.

# License
This project is open-source and available under the MIT License. 
