Problem Definition
The goal of this project is to develop a medication reminder application that helps patients manage their medication schedules. The application notifies users when it is time to take their medication, ensuring adherence to their prescribed treatment plan. The system allows users to log their medications with specific details such as name, dosage, intake instructions, quantity, and any special instructions.

Methodology
The application follows a structured methodology to ensure accurate and timely medication reminders:

User Registration and Login:

Users can register and log in to the application using their email and password. User data is stored securely in a MongoDB database.
Medication Logging:

Users can log their medications through a form that captures details such as medication name, dosage, intake instructions, quantity, special instructions, and the time they need to take it.
Reminder Setup:

The application sets up a timer to periodically check if any medication reminders need to be triggered. This is done by comparing the current time with the scheduled time for each medication.
Notification System:

When the time for a medication arrives, the application sends a notification to the user, reminding them to take their medication.
Data Management:

All user and medication data are stored and managed using MongoDB. The database interactions are handled using the MongoDB C# driver.
Toolkit
The application leverages the following tools and technologies:

Programming Language:

C# with .NET Framework for building the application.
Database:

MongoDB for storing user and medication data.
IDE:

Visual Studio for development.
UI Components:

Windows Forms for the user interface.
Libraries and Packages:

MongoDB.Driver: For MongoDB interactions.
System.Timers: For setting up periodic checks for medication reminders.
Test Cases
The following test cases were used to validate the functionality of the application:

User Registration:

Verify that a new user can register with a unique email and password.
Ensure that appropriate error messages are displayed for duplicate emails.
User Login:

Validate that registered users can log in with correct credentials.
Ensure that invalid credentials display an error message.
Medication Logging:

Check that users can add medications with all required details.
Verify that the data is correctly stored in the MongoDB database.
Reminder Notifications:

Confirm that the application sends a reminder notification at the correct time.
Test the handling of multiple medications with different schedules.
Data Retrieval:

Ensure that logged medications are correctly retrieved and displayed in the user interface.
Work Distribution
The project was developed collaboratively with clear division of tasks:

User Interface Design:

Designing the Windows Forms interface for registration, login, and medication logging.
Responsible: [Fahira]
Database Setup and Management:

Setting up MongoDB and creating collections for users and medications.
Responsible: [Azzam]
Core Functionality Implementation:

Implementing user registration, login, and medication logging.
Responsible: [Azzam]
Reminder System:

Developing the reminder notification system using System.Timers.
Responsible: [Azzam]

Documentation:

Creating project documentation and README.
Responsible: [Azzam}
Conclusion
This medication reminder application aims to improve medication adherence by providing timely notifications to users. The use of MongoDB ensures efficient data management, and the application’s design makes it user-friendly. The collaborative effort resulted in a functional and effective solution to a common healthcare problem.
